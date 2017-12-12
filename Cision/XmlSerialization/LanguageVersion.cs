using System;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// LanguageVersion element datails.
        /// </summary>
        [Serializable]
        [XmlType("LanguageVersion")]
        public class LanguageVersion
        {
            [XmlAttribute]
            public string LangugeCode { get; set; }

            [XmlAttribute]
            public int ReleaseId { get; set; }
        }
    }
}