namespace WebScrapper.Models
{
    public class MediaPageCommonFilterModel: MediaPageFilterModel
    {
        public string MediaType { get; set; }

        public string ArticleType { get; set; }

        public string Category { get; set; }

        public MediaPageCommonFilterModel() { }

        public MediaPageCommonFilterModel(string year, string month, string mediaType, string articleType)
        {
            Year = year;
            Month = month;
            MediaType = mediaType;
            ArticleType = articleType;
        }

        public MediaPageCommonFilterModel(string year, string month, string articleType, string pageTitle, string isCrawled)
        {
            Year = year;
            Month = month;
            ArticleType = articleType;
            PageTitle = pageTitle;

            if (string.IsNullOrEmpty(isCrawled))
            {
                IsCrawled = null;
            }
            else
            {
                IsCrawled = isCrawled.Equals("Yes");
            }
        }

        public MediaPageCommonFilterModel(string year, string month, string mediaType, string articleType, string category, string pageTitle, string isCrawled)
        {
            Year = year;
            Month = month;
            MediaType = mediaType;
            ArticleType = articleType;
            Category = category;
            PageTitle = pageTitle;

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
