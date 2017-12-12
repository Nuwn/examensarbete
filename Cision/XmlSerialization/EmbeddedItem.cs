using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// EmbeddedItem element.
        /// </summary>
        [Serializable]
        [XmlType("EmbeddedItem>")]
        public class EmbeddedItem
        {
            [XmlAttribute]
            public DateTime CreateDateUtc { get; set; }

            [XmlAttribute]
            public string EmbedHost { get; set; }

            [XmlElement]
            public string Title { get; set; }

            [XmlElement]
            public string Description { get; set; }

            [XmlElement]
            public string EmbedCode { get; set; }

            [XmlElement]
            public string ThumbnailUrl { get; set; }

            [XmlElement]
            public string LargeThumbnailUrl { get; set; }

            [XmlArray("Keywords"), XmlArrayItem("Keyword")]
            public List<Keyword> Keywords { get; set; }
        }
    }
}