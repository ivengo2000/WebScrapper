namespace WebScrapper.Models
{
    public class MediaPageListBaseModel
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Path { get; set; }

        [System.ComponentModel.DisplayName("Is Crawled")]
        public bool IsCrawled { get; set; }

        public MediaPageListBaseModel() { }

        public MediaPageListBaseModel(MediaPagesDbModel dbModel)
        {
            Id = dbModel.Id;
            Url = dbModel.Url;
            Path = dbModel.Path;
            IsCrawled = dbModel.IsCrawled;
        }
    }
}
