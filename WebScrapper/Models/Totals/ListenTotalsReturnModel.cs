namespace WebScrapper.Models.Totals
{
    public class ListenTotalsReturnModel: BaseTotalsResult
    {
        public int EventsCount { get; set; }

        public int InterviewsCount { get; set; }

        public int SpecialBroadcastsCount { get; set; }

        public int TeachingCount { get; set; }

        public int UnCategorizedCount { get; set; }

        public ListenTotalsReturnModel() { }

        public ListenTotalsReturnModel(int eventsCount, int interviewsCount, int specialBroadcastsCount, int teachingCount, int unCategorizedCount, int count, int crawledCount, int nonCrawledCount)
        {
            EventsCount = eventsCount;
            InterviewsCount = interviewsCount;
            SpecialBroadcastsCount = specialBroadcastsCount;
            TeachingCount = teachingCount;
            UnCategorizedCount = unCategorizedCount;
            Count = count;
            CrawledCount = crawledCount;
            NonCrawledCount = nonCrawledCount;
        }
    }
}
