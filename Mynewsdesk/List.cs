

using Newtonsoft.Json.Linq;
using Spctrm_news.Mynewsdesk.JsonSerialization;
using System.Collections.Generic;

namespace Spctrm_news.Mynewsdesk
{
    public class List : News
    {
        public List(int CacheMinutes = 20, bool Caching = false) : base(CacheMinutes, Caching){ }

        public dynamic Get(Settings data, string returns = "c#")
        {
            string BaseURL = "http://www.mynewsdesk.com/services/pressroom/list/" + data.key + "/";

            string json = CreateURL(BaseURL, data, new List<string>{ "key", "item_id" });

            return Translate<Items>(GetJSON(json, "items"), returns);
        }
    }
}