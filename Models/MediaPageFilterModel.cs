namespace WebScrapper.Models
{
    public class MediaPageFilterModel
    {
        public string Year { get; set; }

        public string Month { get; set; }

        public string PageTitle { get; set; }

        public bool? IsCrawled { get; set; }

        public MediaPageFilterModel() { }

        public MediaPageFilterModel(string year, string month, string pageTitle)
        {
            Year = year;
            Month = month;
            PageTitle = pageTitle;
        }

        public MediaPageFilterModel(string year, string month, string pageTitle, string isCrawled): this(year, month, pageTitle)
        {
            if (string.IsNullOrEmpty(isCrawled))
            {
                IsCrawled = null;
            }
            else
            {
                IsCrawled = isCrawled.Equals("Yes");
            }
        }
    }
}
