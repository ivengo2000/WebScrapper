namespace WebScrapper.Utilities
{
    public static class Consts
    {
        public static class Paths
        {
            public const string Home = "/sitecore/content/LTW/home/";

            public static readonly string MyDevotionalPath = $"{Home}read/my-devotional/";

            public static readonly string ArticlesPath = $"{Home}read/articles/";

            public static readonly string PrayerPath = $"{Home}read/prayer/";
        }

        public static class MediaTypes
        {
            public const string Read = "Read";

            public const string Listen = "Listen";

            public const string Watch = "Watch";
        }

        public static class Articles
        {
            public const string ArticlesCategory = "Articles";

            public const string Article = "Article";

            public const string MyDevotional = "My Devotional";

            public const string MyJournal = "My Journal";

            public const string Prayer = "Prayer";

            public enum ArticleTypes
            {
                Article,
                MyDevotional,
                MyJournal,
                Prayer
            }
        }

        public static class Listens
        {
            public const string Events = "Events";

            public const string Interviews = "Interviews";

            public const string SpecialBroadcasts = "Special Broadcasts";

            public const string Teaching = "Teaching";

            public const string UnCategorized = "Uncategorized";
        }

        public static class Watches
        {
            public const string Events = "Events";

            public const string Interviews = "Interviews";

            public const string SpecialBroadcasts = "Special Broadcasts";

            public const string Teaching = "Teaching";

            public const string Testimonials = "Testimonials";

            public const string UnCategorized = "Uncategorized";

            public const string Video = "Video";
        }

        public static class ExportFilePrefixes
        {
            public const string Article = "artcl-";

            public const string MyDevotional = "my-devo-";

            public const string MyJournal = "my-jrnl-";

            public const string Prayer = "prayer-";

            public const string ListenEvents = "listen-events-";

            public const string ListenInterviews = "listen-interviews-";

            public const string ListenSpecialBroadcasts = "listen-spec-broadcasts-";

            public const string ListenTeaching = "listen-teach-";

            public const string ListenUnCategorized = "listen-uncategor-";

            public const string WatchEvents = "watch-uncategor-";
            
            public const string WatchInterviews = "watch-interviews-";
            
            public const string WatchSpecialBroadcasts = "watch-spec-broadcasts-";
            
            public const string WatchTeaching = "watch-teach-";
            
            public const string WatchTestimonies = "watch-testimonies-";
            
            public const string WatchUnCategorized = "watch-uncategor-";
            
            public const string WatchVideo = "watch-video-";
        }

        public static class Urls
        {
            public const string UatHome = "https://uat.leadingtheway.org/";

            public const string ProdHome = "https://www.ltw.org/";
        }

        public static class Db
        {
            public const string Name = "WebCrawlerData.db";

            public const string MediaPages = "MediaPages";
        }
    }
}
