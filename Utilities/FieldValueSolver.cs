using WebScrapper.Models;

namespace WebScrapper.Utilities
{
    public static class FieldValueSolver
    {
        public static string GetArticleTypeFieldValue(Consts.Articles.ArticleTypes articleType)
        {
            var result = string.Empty;
            switch (articleType)
            {
                case Consts.Articles.ArticleTypes.Article:
                    result = Consts.Articles.Article;
                    break;
                case Consts.Articles.ArticleTypes.MyDevotional:
                    result = Consts.Articles.MyDevotional;
                    break;
                case Consts.Articles.ArticleTypes.MyJournal:
                    result = Consts.Articles.MyJournal;
                    break;
                case Consts.Articles.ArticleTypes.Prayer:
                    result = Consts.Articles.Prayer;
                    break;
            }

            return result;
        }

        public static string GetListenCategoryFieldValue(ListensModel.CategoryTypes categoryType)
        {
            var result = string.Empty;
            switch (categoryType)
            {
                case ListensModel.CategoryTypes.Events:
                    result = Consts.Listens.Events;
                    break;
                case ListensModel.CategoryTypes.Interviews:
                    result = Consts.Listens.Interviews;
                    break;
                case ListensModel.CategoryTypes.SpecialBroadcasts:
                    result = Consts.Listens.SpecialBroadcasts;
                    break;
                case ListensModel.CategoryTypes.Teaching:
                    result = Consts.Listens.Teaching;
                    break;
            }

            return result;
        }

        public static string GetWatchCategoryFieldValue(WatchesModel.CategoryTypes categoryType)
        {
            var result = string.Empty;
            switch (categoryType)
            {
                case WatchesModel.CategoryTypes.Events:
                    result = Consts.Watches.Events;
                    break;
                case WatchesModel.CategoryTypes.Interviews:
                    result = Consts.Watches.Interviews;
                    break;
                case WatchesModel.CategoryTypes.SpecialBroadcasts:
                    result = Consts.Watches.SpecialBroadcasts;
                    break;
                case WatchesModel.CategoryTypes.Teaching:
                    result = Consts.Watches.Teaching;
                    break;
                case WatchesModel.CategoryTypes.Testimonials:
                    result = Consts.Watches.Testimonials;
                    break;
                case WatchesModel.CategoryTypes.Video:
                    result = Consts.Watches.Video;
                    break;
            }

            return result;
        }
    }
}
