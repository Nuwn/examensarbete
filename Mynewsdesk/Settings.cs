using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spctrm_news.Mynewsdesk
{
    public class Settings
    {
        public string key { get; set; }
        public int item_id { get; set; }
        public string type_of_media { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public string order { get; set; }
        public string format { get; set; }
        public string pressroom { get; set; }
        public bool archived { get; set; }
        public string locale { get; set; }

        public Settings(string key,
                        int item_id = 0,
                        string type_of_media = null,
                        int limit = 20,
                        int offset = 0,
                        string order = null,
                        string pressroom = null,
                        bool archived = false,
                        string locale = null)
        {

            this.key = key;
            this.item_id = item_id;
            this.type_of_media = type_of_media;
            this.limit = limit;
            this.offset = offset;
            this.order = order;
            this.pressroom = pressroom;
            this.archived = archived;
            this.format = "json";
            this.locale = locale;
        }
    }
}
