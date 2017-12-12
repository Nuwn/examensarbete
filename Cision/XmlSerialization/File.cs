using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// File element.
        /// </summary>
        [Serializable]
        [XmlType("File")]
        public class File
        {
            [XmlAttribute]
            public DateTime CreateDateUtc { get; set; }

            [XmlElement]
            public string Title { get; set; }

            [XmlElement]
            public string Description { get; set; }

            [XmlElement]
            public string FileName { get; set; }

            [XmlElement]
            public string Url { get; set; }
        }
    }
}