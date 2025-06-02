namespace WebScrapper.Models.Totals
{
    public class MediaPagesTotalsReturnModel: BaseTotalsResult
    {
        public int ReadPagesCount { get; set; }

        public int ListenPagesCount { get; set; }

        public int WatchPagesCount { get; set; }

        public ReadTotalsReturnModel ReadTotals { get; set; }

        public ListenTotalsReturnModel ListenTotals { get; set; }

        public WatchTotalsReturnModel WatchTotals { get; set; }
    }
}
