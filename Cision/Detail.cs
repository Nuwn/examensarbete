using Spctrm_news.Cision.XmlSerialization;


namespace Spctrm_news.Cision
{
    public class Detail : News
    {
        public Detail(int CacheMinutes = 20, bool Caching = false) : base(CacheMinutes, Caching){}

        public dynamic Get(int ID, string returns = "c#")
        {
            string url = "http://publish.ne.cision.com/v2.0/Release/GetReleaseDetail?releaseId=";

            return Translate<ReleaseDetail>(GetXML(url + ID), returns);
        }
    }
}