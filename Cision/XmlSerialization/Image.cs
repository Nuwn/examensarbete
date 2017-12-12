using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// Image element details.
        /// </summary>
        [Serializable]
        [XmlType("Image")]
        public class Image
        {
            [XmlAttribute]
            public DateTime CreateDateUtc { get; set; }

            [XmlAttribute]
            public string FileName { get; set; }

            [XmlElement]
            public string Title { get; set; }

            [XmlElement]
            public string Description { get; set; }

            [XmlElement("HighQualityUrl")]
            public string Large { get; set; }

            [XmlElement("LowQualityUrl")]
            public string Small { get; set; }

            [XmlElement("ThumbnailUrl")]
            public string Thumbnail_large  { get; set; }
        }
    }
}