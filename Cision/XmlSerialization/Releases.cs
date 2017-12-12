using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Spctrm_news
{
    namespace Cision.XmlSerialization
    {
        /// <summary>
        /// The main XML feed entities.
        /// </summary>
        [Serializable]
        [XmlRoot("Releases")]
        public class Items
        {
            // PageIndex="1" PageSize="50" TotalHits="211" SearchTime="0"
            [XmlAttribute("PageIndex")]
            public int Pageindex { get; set; }

            [XmlAttribute("PageSize")]
            public int Pagesize { get; set; }

            [XmlAttribute("TotalHits")]
            public int Total { get; set; }

            [XmlAttribute("SearchTime")]
            public double Searchtime { get; set; }

            [XmlElement("Release")]
            public List<Release> Item { get; set; }
        }
    }
}