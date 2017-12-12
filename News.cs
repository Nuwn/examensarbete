using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Spctrm_news
{
    public class News
    {
        protected bool Caching = false;
        protected int CacheMinutes = 20;

        public News (int CacheMinutes = 20, bool Caching = false)
        {
            this.Caching = Caching;
            this.CacheMinutes = CacheMinutes;
        }

        /// <summary>
        /// Simply collects the XML from a URI
        /// </summary>
        /// <param name="uri">The uri to get data from.</param>
        /// <returns>Returns an XDocument with data to use later.</returns>
        protected XDocument GetXML(string url)
        {
            return (Caching) ? (CheckCache(url)) ? Cache(url) : Cache(url, XDocument.Load(url), CacheMinutes) : XDocument.Load(url);
        }

        /// <summary>
        /// Collects a json string if preferred.
        /// </summary>
        /// <param name="url">The uri to get data from.</param>
        /// <returns>Returns a json string</returns>
        protected string GetJSON(string url, string StartToken = null)
        {
            var json = "";
            try {
                json = (Caching) ? 
                    (CheckCache(url)) ? 
                        Cache(url) : 
                        Cache(url, new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url), CacheMinutes) :
                    new WebClient() { Encoding = Encoding.UTF8 }.DownloadString(url);
            }
            catch (WebException ex)
            {
                throw new ArgumentNullException(ex + " - This may be caused by an incorrect url string.");
            } 
            try
            {
                json = (StartToken != null) ? JObject.Parse(json).SelectToken(StartToken).ToString()  : json ;
            } catch (Exception ex)
            {
                throw new ArgumentNullException(ex + " - unable to decode, control StartToken");
            }
            return json;
        }

        /// <summary>
        /// Deserializes XDocument XML data to an object, An object needs to be passed matching the XML data to parse with.
        /// </summary>
        /// <param name="XML">The XDocument XML data</param>
        /// <param name="T">The object Type , pass in e.g typeof(Spctrm.News.Cision.XmlSerialization.Releases)</param>
        /// <returns>Returns a new object with data from XML</returns>
        public static T xml_deserialize<T>(XDocument XML)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            T obj;
            using (XmlReader reader = XmlReader.Create(new StringReader(XML.ToString())))
            {
                obj = (T)deserializer.Deserialize(reader);
            }
            return obj;
        }

        /// <summary>
        /// encodes the object given from xml or of your choice.
        /// Uses the reference Newtonsoft.json.
        /// </summary>
        /// <param name="obj">The object to encode</param>
        /// <returns>Json string</returns>
        public static string json_encode(dynamic obj)
        {
            string json = (obj is XDocument) ? JsonConvert.SerializeObject(obj.Root) : JsonConvert.SerializeObject(obj);
            json = json.Replace(@"\", " ");
            json = json.Replace(@"@", "");
            return json;
        }

        /// <summary>
        /// decodes a json string to an object.
        /// </summary>
        /// <param name="json">Json string</param>
        /// <returns>a new object from the json data</returns>
        public static T json_decode<T>(string json)
        {
                return JsonConvert.DeserializeObject<T>(json);
        }


        /// <summary>
        /// Creates the get URL from a object
        /// </summary>
        /// <param name="T">the Data class name</param>
        /// <param name="BaseURL">the url excluding the get params</param>
        /// <param name="Properties">the object to make url from</param>
        /// <param name="Exclude">the object properties(names) to exclude from the url</param>
        /// <returns>a new object from the json data</returns>
        protected static string CreateURL(string BaseUrl, dynamic Properties, List<string> Exclude = null)
        {
            string URL = BaseUrl;
            int count = 0;
            foreach (PropertyInfo property in Properties.GetType().GetProperties())
            {
                if(Exclude != null)
                {
                    if (!Exclude.Any(str => str.Contains(property.Name)))
                    {
                        if (property.GetValue(Properties, null) != null)
                        {
                            URL += (count == 0) ? "?" : "&";
                            URL += (property.Name + "=" + property.GetValue(Properties, null));
                            count++;
                        }
                    }
                }
                else
                {
                    if (property.GetValue(Properties, null) != null)
                    {
                        URL += (count == 0) ? "?" : "&";
                        URL += (property.Name + "=" + property.GetValue(Properties, null));
                        count++;
                    }
                }    
            }
            return URL;
        }

        /// <summary>
        /// Serializes into desired format.
        /// </summary>
        /// <param name="data">XDocument XML, Json </param>
        /// <returns>json or object</returns>
        public static dynamic Translate<T>(dynamic data, string returns = "default")
        {
            Type a = (Type)data.GetType();
            returns = (returns == "default") ? a.ToString() : returns;
            switch (returns.ToLower())
            {
                case "object":
                default:
                    return (data is XDocument) ? xml_deserialize<T>(data) : json_decode<T>(data);

                case "json":
                    return (data is XDocument) ? json_encode(data) : data;
            }
        }

        protected static bool CheckCache(string url)
        {
            return (System.Web.HttpRuntime.Cache[url] == null) ? false: true;   
        }

        protected static dynamic Cache ( string url, dynamic data = null, int minutes = 20)
        {
            if (System.Web.HttpRuntime.Cache[url] != null)
            {
                return System.Web.HttpRuntime.Cache.Get(url);
            } else
            {
                System.Web.HttpRuntime.Cache.Insert(url, data, null, DateTime.Now.AddMinutes(minutes), System.Web.Caching.Cache.NoSlidingExpiration);
                return data;
            }
        }
    }
}