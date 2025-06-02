namespace WebScrapper.Models.Totals
{
    public class WatchTotalsReturnModel: BaseTotalsResult
    {
        public int EventsCount { get; set; }

        public int InterviewsCount { get; set; }

        public int SpecialBroadcastsCount { get; set; }

        public int TeachingCount { get; set; }

        public int TestimonialsCount { get; set; }

        public int UnCategorizedCount { get; set; }

        public int VideoCount { get; set; }

        public WatchTotalsReturnModel() { }

        public WatchTotalsReturnModel(int eventsCount, int interviewsCount, int specialBroadcastsCount, int teachingCount, int testimonialsCount, 
                                            int unCategorizedCount, int videoCount, int count, int crawledCount, int nonCrawledCount)
        {
            EventsCount = eventsCount;
            InterviewsCount = interviewsCount;
            SpecialBroadcastsCount = specialBroadcastsCount;
            TeachingCount = teachingCount;
            TestimonialsCount = testimonialsCount;
            UnCategorizedCount = unCategorizedCount;
            VideoCount = videoCount;
            Count = count;
            CrawledCount = crawledCount;
            NonCrawledCount = nonCrawledCount;
        }
    }
}
