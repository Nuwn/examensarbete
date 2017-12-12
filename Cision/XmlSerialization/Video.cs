using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// Video element details.
        /// </summary>
        [Serializable]
        [XmlType("Video")]
        public class Video
        {
            [XmlAttribute]
            public double Height { get; set; }

            [XmlAttribute]
            public double Width { get; set; }

            [XmlAttribute]
            public DateTime CreateDateUtc { get; set; }

            [XmlElement]
            public string Title { get; set; }

            [XmlElement]
            public string Description { get; set; }

            [XmlElement]
            public string PlayerUrl { get; set; }

            [XmlElement]
            public string EmbedCode { get; set; }

            [XmlElement]
            public string ThumbnailUrl { get; set; }
        }
    }
}