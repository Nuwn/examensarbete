using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// Keyword element details.
        /// </summary>
        [Serializable]
        [XmlType("Keyword")]
        public class Keyword
        {
            [XmlElement("Value")]
            public string Value { get; set; }
        }
    }
}