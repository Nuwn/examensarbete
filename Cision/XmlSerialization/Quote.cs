using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        [Serializable]
        [XmlType("Quote")]
        public class Quote
        {
            [XmlAttribute("Author")]
            public string Author { get; set; }
        }
    }
}