using System;

namespace WebScrapper.Models
{
    public class MediaPagesDbModel : MediaPageModel
    {
        [System.ComponentModel.DisplayName("Year")]
        public string Year { get; set; }

        [System.ComponentModel.DisplayName("Month")]
        public string Month { get; set; }

        [System.ComponentModel.DisplayName("Day")]
        public string Day { get; set; }

        [System.ComponentModel.DisplayName("IsCrawled")]
        public bool IsCrawled { get; set; }

        public string PageMarkup { get; set; }

        public DateTime CreatedDate { get; set; }

        [System.ComponentModel.DisplayName("Media Type")]
        public string MediaType { get; set; }
    }
}
