using WebScrapper.Models;

namespace WebScrapper.Utilities
{
    public static class FileNameSolver
    {
        public static string GetListenInitialExcelFileName(ListensModel.CategoryTypes categoryType)
        {
            var result = string.Empty;
            
            switch (categoryType)
            {
                case ListensModel.CategoryTypes.Events:
                    result = Consts.ExportFilePrefixes.ListenEvents;
                    break;
                case ListensModel.CategoryTypes.Interviews:
                    result = Consts.ExportFilePrefixes.ListenInterviews;
                    break;
                case ListensModel.CategoryTypes.SpecialBroadcasts:
                    result = Consts.ExportFilePrefixes.ListenSpecialBroadcasts;
                    break;
                case ListensModel.CategoryTypes.Teaching:
                    result = Consts.ExportFilePrefixes.ListenTeaching;
                    break;
                case ListensModel.CategoryTypes.UnCategorized:
                    result = Consts.ExportFilePrefixes.ListenUnCategorized;
                    break;
            }

            return result;
        }

        public static string GetWatchInitialExcelFileName(WatchesModel.CategoryTypes categoryType)
        {
            var result = string.Empty;
            
            switch (categoryType)
            {
                case WatchesModel.CategoryTypes.Events:
                    result = Consts.ExportFilePrefixes.WatchEvents;
                    break;
                case WatchesModel.CategoryTypes.Interviews:
                    result = Consts.ExportFilePrefixes.WatchInterviews;
                    break;
                case WatchesModel.CategoryTypes.SpecialBroadcasts:
                    result = Consts.ExportFilePrefixes.WatchSpecialBroadcasts;
                    break;
                case WatchesModel.CategoryTypes.Teaching:
                    result = Consts.ExportFilePrefixes.WatchTeaching;
                    break;
                case WatchesModel.CategoryTypes.Testimonials:
                    result = Consts.ExportFilePrefixes.WatchTestimonies;
                    break;
                case WatchesModel.CategoryTypes.UnCategorized:
                    result = Consts.ExportFilePrefixes.WatchUnCategorized;
                    break;
                case WatchesModel.CategoryTypes.Video:
                    result = Consts.ExportFilePrefixes.WatchVideo;
                    break;
            }

            return result;
        }
    }
}
