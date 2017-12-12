using Spctrm_news.Mynewsdesk.JsonSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spctrm_news.Mynewsdesk
{
    public class Detail : News
    {
        public Detail(int CacheMinutes = 20, bool Caching = false) : base(CacheMinutes, Caching){}


        public dynamic Get(Settings data, string returns = "c#")
        {
            string BaseURL = "http://www.mynewsdesk.com/services/pressroom/view/" + data.key + "/";

            string json = CreateURL(BaseURL, data, new List<string> { "key" });

            return Translate<Item>(GetJSON(json, "item"), returns);
        }
    }
}
