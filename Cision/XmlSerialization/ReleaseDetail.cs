using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// Detail element fetched from detail url in CisionRelease.
        /// </summary>
        [Serializable]
        [XmlRoot("Release")]
        public class ReleaseDetail
        {
            [XmlAttribute]
            public int Id { get; set; }

            [XmlAttribute]
            public string InformationType { get; set; }

            [XmlAttribute]
            public DateTime PublishDateUtc { get; set; }

            [XmlAttribute]
            public DateTime LastChangeDateUtc { get; set; }

            [XmlAttribute]
            public string LanguageCode { get; set; }

            [XmlAttribute]
            public string CountryCode { get; set; }

            [XmlElement]
            public string SyndicatedUrl { get; set; }

            [XmlElement]
            public string SourceName { get; set; }

            [XmlElement]
            public string SeOrganizationNumber { get; set; }

            [XmlElement]
            public bool SourceIsListed { get; set; }

            [XmlElement]
            public int IptcCode { get; set; }

            [XmlElement]
            public string CustomerReference { get; set; }

            [XmlElement]
            public string Title { get; set; }

            [XmlElement]
            public string Header { get; set; }

            [XmlElement]
            public string Intro { get; set; }

            [XmlElement]
            public string Body { get; set; }

            [XmlElement]
            public string CompanyInformation { get; set; }

            [XmlElement]
            public string Complete { get; set; }

            [XmlElement]
            public string Contact { get; set; }

            [XmlElement]
            public string HtmlTitle { get; set; }

            [XmlElement]
            public string HtmlIntro { get; set; }

            [XmlElement]
            public string HtmlHeader { get; set; }

            [XmlElement]
            public string HtmlBody { get; set; }

            [XmlElement]
            public string HtmlContact { get; set; }

            [XmlElement]
            public string HtmlCompanyInformation { get; set; }

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

            [XmlElement]
            public string SocialMediaPitch { get; set; }

            [XmlArray("EmbeddedItems"), XmlArrayItem("EmbeddedItem")]
            public List<EmbeddedItem> EmbeddedItems { get; set; }

            [XmlElement]
            public bool IsRegulatory { get; set; }
        }
    }
}