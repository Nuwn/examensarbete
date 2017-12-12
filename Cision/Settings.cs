namespace Spctrm_news
{
    namespace Cision
    {
        public class Settings
        {
            public string feedUniqueIdentifier { get; set; }
            public string sorting { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
            public int pageSize { get; set; }
            public int pageIndex { get; set; }
            public string tags { get; set; }
            public string detailLevel { get; set; }

            public Settings(string feedUniqueIdentifier,
                            string sorting = "ListReleasesSortedByPublishDate",
                            string startDate = null,
                            string endDate = null,
                            int pageSize = 50,
                            int pageIndex = 0,
                            string tags = null,
                            string detailLevel = null)
            {
                this.feedUniqueIdentifier = feedUniqueIdentifier;
                this.sorting = sorting;
                this.startDate = startDate;
                this.endDate = endDate;
                this.pageSize = pageSize;
                this.pageIndex = pageIndex;
                this.tags = tags;
                this.detailLevel = detailLevel;
            }
        }
    }
}