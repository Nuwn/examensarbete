using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// Category element details.
        /// </summary>
        [Serializable]
        [XmlType("Category")]
        public class Category
        {
            [XmlElement]
            public string Name { get; set; }

            [XmlElement]
            public string Code { get; set; }
        }
    }
}