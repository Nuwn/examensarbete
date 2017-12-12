
using Spctrm_news.Cision.XmlSerialization;
using System;
using System.Collections.Generic;

namespace Spctrm_news.Cision
{
    public class List : News
    {
        public List(int CacheMinutes = 20, bool Caching = false) : base(CacheMinutes, Caching){ }

        public dynamic Get(Settings data, string returns = "c#")
        {
            string BaseURLxml = "http://publish.ne.cision.com/Release/" + data.sorting + "/";

            string URL = CreateURL(BaseURLxml, data, new List<string> {"sorting"});

            return Translate<Items>(GetXML(URL), returns);
        }
        
    }
}