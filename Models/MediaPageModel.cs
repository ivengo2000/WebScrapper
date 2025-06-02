using WebScrapper.Helpers;

namespace WebScrapper.Models
{
    public class MediaPageModel
    {
        [FieldName("ID")] 
        public string Id { get; set; }

        public string Url { get; set; }

        public string Path { get; set; }

        [FieldName("Page Title")] 
        public string PageTitle { get; set; }

        public string PostedDate { get; set; }

        public string ArticleType { get; set; }

        [FieldName("Open Graph Page Title")] 
        public string OpenGraphPageTitle { get; set; }

        [FieldName("Open Graph Description")] 
        public string OpenGraphDescription { get; set; }

        [FieldName("Meta Description")] 
        public string MetaDescription { get; set; }

        [FieldName("Open Graph Image")] 
        public string OpenGraphImage { get; set; }

        [FieldName("Default Title")] 
        public string DefaultTitle { get; set; }

        public string Scripture { get; set; }

        [FieldName("Short Description")] 
        public string ShortDescription { get; set; }

        public string Tags { get; set; }

        [FieldName("ImageURL")] 
        public string ImageUrl { get; set; }

        public string Category { get; set; }

        public string Topic { get; set; }

        public string MediaAuthor { get; set; }

        [FieldName("Download URL")] 
        public string DownloadUrl { get; set; }

        [FieldName("Purchase URL")] 
        public string PurchaseUrl { get; set; }

        [FieldName("Media Description")] 
        public string MediaDescription { get; set; }

        public string Content { get; set; }

        public string PullQuote { get; set; }

        [FieldName("Audio Video URL")] 
        public string AudioVideoUrl { get; set; }

        [FieldName("Audio Video Subtitles URL")]
        public string AudioVideoSubtitlesUrl { get; set; }

        [FieldName("Change Audio Video URL")] 
        public string ChangeAudioVideoUrl { get; set; }
    }
}
