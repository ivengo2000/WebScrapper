namespace WebScrapper.Models.Totals
{
    public class ReadTotalsReturnModel: BaseTotalsResult
    {
        public int ArticlesCount { get; set; }

        public int MyDevotionalsCount { get; set; }

        public int MyJournalsCount { get; set; }

        public int PrayersCount { get; set; }

        public ReadTotalsReturnModel() { }

        public ReadTotalsReturnModel(int articlesCount, int myDevotionalsCount, int myJournalsCount, int prayersCount, int count, int crawledCount, int nonCrawledCount)
        {
            ArticlesCount = articlesCount;
            MyDevotionalsCount = myDevotionalsCount;
            MyJournalsCount = myJournalsCount;
            PrayersCount = prayersCount;
            Count = count;
            CrawledCount = crawledCount;
            NonCrawledCount = nonCrawledCount;
        }
    }
}
