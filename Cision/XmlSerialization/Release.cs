using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// Element of Releases.
        /// </summary>
        [Serializable]
        [XmlRoot("Release")]
        public class Release
        {
            // Id="2423232" InformationType="PRM" PublishDateUtc="2017-01-10T12:35:29" LastChangeDateUtc="2017-01-10T12:35:37" LanguageCode="sv" CountryCode="se"
            // DetailUrl="http://publish.ne.cision.com/v2.0/Release/GetDetail/6A676224962C4BDA" CisionWireUrl="http://news.cision.com/se/sintercast/r/ford-visar-f-150-diesel-vid-north-american-international-auto-show,c2162196"
            // LogoUrl="http://mb.cision.com/Public/15118/logo/8a4e2d7a93fd7605_org.gif" SourceId="30628" RawHtmlUrl="http://publish.ne.cision.com/v2.0/Release/ViewReleaseHtml/6A676224962C4BDA" CanonicalUrl=""
            
            [XmlAttribute("Id")]
            public int Id { get; set; }

            [XmlAttribute("InformationType")]
            public string Type { get; set; }

            [XmlAttribute("PublishDateUtc")]
            public DateTime Published { get; set; }

            [XmlAttribute("LastChangeDateUtc")]
            public DateTime Changed { get; set; }

            [XmlAttribute("LanguageCode")]
            public string Language { get; set; }

            [XmlAttribute("CountryCode")]
            public string CountryCode { get; set; }

            [XmlAttribute("DetailUrl")]
            public string DetailUrl { get; set; }

            [XmlAttribute("CisionWireUrl")]
            public string CisionWireUrl { get; set; }

            [XmlAttribute("LogoUrl")]
            public string LogoUrl { get; set; }

            [XmlAttribute("SourceId")]
            public int Source_id { get; set; }

            [XmlAttribute("RawHtmlUrl")]
            public string RawHtmlUrl { get; set; }

            [XmlElement("SyndicatedUrl")]
            public string SyndicatedUrl { get; set; }

            [XmlElement("SourceName")]
            public string Source_name { get; set; }

            [XmlElement("SeOrganizationNumber")]
            public string Organization_number { get; set; }

            [XmlElement("SourceIsListed")]
            public bool SourceIsListed { get; set; }

            [XmlElement("IptcCode")]
            public int IptcCode { get; set; }

            [XmlElement("CustomerReference")]
            public string CustomerReference { get; set; }

            [XmlElement("Title")]
            public string Title { get; set; }

            [XmlElement("Intro")]
            public string Content { get; set; }

            [XmlArray("LanguageVersions"), XmlArrayItem("LanguageVersion")]
            public List<LanguageVersion> LanguageVersions { get; set; }

            [XmlArray("Categories"), XmlArrayItem("Category")]
            public List<Category> Categories { get; set; }

            [XmlArray("Keywords"), XmlArrayItem("Keyword")]
            public List<Keyword> KeyWords { get; set; }

            [XmlArray("Images"), XmlArrayItem("Image")]
            public List<Image> Images { get; set; }

            [XmlArray("Videos"), XmlArrayItem("Video")]
            public List<Video> Videos { get; set; }

            [XmlArray("Files"), XmlArrayItem("File")]
            public List<File> Files { get; set; }

            [XmlArray("Quotes"), XmlArrayItem("Quote")]
            public List<Quote> Quotes { get; set; }

            [XmlArray("QuickFacts"), XmlArrayItem("QuickFact")]
            public List<QuickFact> QuickFacts { get; set; }

            [XmlArray("ExternalLinks"), XmlArrayItem("ExternalLink")]
            public List<ExternalLink> ExternalLinks { get; set; }

            [XmlElement("SocialMediaPitch")]
            public string SocialMediaPitch { get; set; }

            [XmlArray("EmbeddedItems"), XmlArrayItem("EmbeddedItem")]
            public List<EmbeddedItem> EmbeddedItems { get; set; }

            [XmlElement("IsRegulatory")]
            public bool IsRegulatory { get; set; }
        }
    }
}