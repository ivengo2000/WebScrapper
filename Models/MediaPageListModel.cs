namespace WebScrapper.Models
{
    public class MediaPageListModel: MediaPageListBaseModel
    {
        [System.ComponentModel.DisplayName("Page Title")]
        public string PageTitle { get; set; }

        [System.ComponentModel.DisplayName("Year")]
        public string Year { get; set; }

        [System.ComponentModel.DisplayName("Month")]
        public string Month { get; set; }

        [System.ComponentModel.DisplayName("Day")]
        public string Day { get; set; }

        public MediaPageListModel() { }

        public MediaPageListModel(MediaPagesDbModel dbModel) : base(dbModel)
        {
            PageTitle = dbModel.PageTitle;
            Year = dbModel.Year;
            Month = dbModel.Month;
            Day = dbModel.Day;
        }
    }
}
