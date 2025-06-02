using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LiteDB;
using WebScrapper.Models;
using WebScrapper.Models.Totals;
using WebScrapper.Utilities;

namespace WebScrapper.Services
{
    public class MediaPagesService
    {
        #region Public Methods

        public List<MediaPagesDbModel> CorrectValuesForMediaPage(List<MediaPageModel> modelList)
        {
            var result = new List<MediaPagesDbModel>();

            foreach (var model in modelList)
            {
                if (string.IsNullOrEmpty(model.Id))
                {
                    continue;
                }

                var year = model.PostedDate.Substring(0, 4);
                var month = model.PostedDate.Substring(4, 2);
                var day = model.PostedDate.Substring(6, 2);

                result.Add(new MediaPagesDbModel
                {
                    Id = model.Id,
                    Url = CorrectUrl(model.Url),
                    Path = CorrectPath(model, year, month),
                    PostedDate = model.PostedDate,
                    PageTitle = model.PageTitle,
                    ArticleType = model.ArticleType,
                    Year = year,
                    Month = month,
                    Day = day,

                    OpenGraphPageTitle = model.OpenGraphPageTitle ?? string.Empty,
                    OpenGraphDescription = model.OpenGraphDescription ?? string.Empty,
                    MetaDescription = model.MetaDescription ?? string.Empty,
                    OpenGraphImage = model.OpenGraphImage ?? string.Empty,
                    DefaultTitle = model.DefaultTitle ?? string.Empty,
                    Scripture = model.Scripture ?? string.Empty,
                    ShortDescription = model.ShortDescription ?? string.Empty,
                    Tags = model.Tags ?? string.Empty,
                    ImageUrl = CorrectUrlProtocol(model.ImageUrl),
                    Category = model.Category ?? string.Empty,
                    Topic = model.Topic ?? string.Empty,
                    MediaAuthor = model.MediaAuthor ?? string.Empty,
                    DownloadUrl = CorrectUrlProtocol(model.DownloadUrl),
                    PurchaseUrl = CorrectUrlProtocol(model.PurchaseUrl),
                    MediaDescription = model.MediaDescription ?? string.Empty,
                    Content = model.Content ?? string.Empty,
                    PullQuote = model.PullQuote ?? string.Empty,
                    AudioVideoUrl = CorrectUrlProtocol(model.AudioVideoUrl),
                    AudioVideoSubtitlesUrl = CorrectUrlProtocol(model.AudioVideoSubtitlesUrl),
                    ChangeAudioVideoUrl = CorrectUrlProtocol(model.ChangeAudioVideoUrl)
                });
            }

            return result;
        }

        public bool AddToDb(List<MediaPagesDbModel> modelList, string mediaType = null)
        {
            if (modelList == null || !modelList.Any())
            {
                return false;
            }

            try
            {
                var isMediaTypeNotNull = !string.IsNullOrEmpty(mediaType);
                using (var db = new LiteDatabase(Consts.Db.Name))
                {
                    var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                    foreach (var model in modelList)
                    {
                        var aMediaPage = col.Find(x => x.Id.Equals(model.Id)).FirstOrDefault();
                        if (aMediaPage != null)
                        {
                            if (ExtendMediaPage(aMediaPage, model))
                            {
                                if (isMediaTypeNotNull)
                                {
                                    aMediaPage.MediaType = mediaType;
                                }

                                col.Update(aMediaPage);
                            }
                        }
                        else
                        {
                            model.CreatedDate = DateTime.UtcNow;

                            if (isMediaTypeNotNull)
                            {
                                model.MediaType = mediaType;
                            }

                            // Create unique index in Id field
                            col.EnsureIndex(x => x.Id, true);

                            // Insert new Media Page
                            col.Insert(model);
                        }
                    }
                }

                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public List<MediaPagesDbModel> GetMyDevotionals(MediaPageFilterModel filterModel)
        {
            return GetArticlesCommon(filterModel, Consts.Articles.ArticleTypes.MyDevotional);
        }

        public List<MediaPagesDbModel> GetArticles(MediaPageFilterModel filterModel)
        {
            return GetArticlesCommon(filterModel, Consts.Articles.ArticleTypes.Article);
        }

        public List<MediaPagesDbModel> GetMyJournals(MediaPageFilterModel filterModel)
        {
            return GetArticlesCommon(filterModel, Consts.Articles.ArticleTypes.MyJournal);
        }

        public List<MediaPagesDbModel> GetPrayers(MediaPageFilterModel filterModel)
        {
            return GetArticlesCommon(filterModel, Consts.Articles.ArticleTypes.Prayer);
        }

        public MediaPageListResultModel GetMyDevotionalsLight(MediaPageFilterModel filterModel)
        {
            return GetArticlesLightCommon(filterModel, Consts.Articles.ArticleTypes.MyDevotional);
        }

        public MediaPageListResultModel GetArticlesLight(MediaPageFilterModel filterModel)
        {
            return GetArticlesLightCommon(filterModel, Consts.Articles.ArticleTypes.Article);
        }

        public MediaPageListResultModel GetMyJournalsLight(MediaPageFilterModel filterModel)
        {
            return GetArticlesLightCommon(filterModel, Consts.Articles.ArticleTypes.MyJournal);
        }

        public MediaPageListResultModel GetPrayersLight(MediaPageFilterModel filterModel)
        {
            return GetArticlesLightCommon(filterModel, Consts.Articles.ArticleTypes.Prayer);
        }

        public MediaPageListResultModel GetMediaPagesLight(MediaPageCommonFilterModel filterModel)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                var found2 = col.Find(predicate).Count();

                var found = col.Find(predicate).Select(x => new MediaPageListModel(x)).ToList();

                var crawledCount = found.Count(x => x.IsCrawled);
                var notCrawledCount = found.Count(x => !x.IsCrawled);

                var pages = found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();

                return new MediaPageListResultModel
                {
                    Pages = pages,
                    Total = pages.Count,
                    Crawled = crawledCount,
                    NotCrawled = notCrawledCount
                };
            }
        }

        public MediaPageListResultModel GetListensLight(MediaPageFilterModel filterModel, ListensModel.CategoryTypes categoryType)
        {
            return GetListensLightCommon(filterModel, categoryType);
        }

        public List<MediaPagesDbModel> GetListens(MediaPageFilterModel filterModel, ListensModel.CategoryTypes categoryType)
        {
            return GetListensCommon(filterModel, categoryType);
        }

        public MediaPageListResultModel GetWatchesLight(MediaPageFilterModel mediaPageFilterModel, WatchesModel.CategoryTypes categoryType)
        {
            return GetWatchesLightCommon(mediaPageFilterModel, categoryType);
        }

        public List<MediaPagesDbModel> GetWatches(MediaPageFilterModel filterModel, WatchesModel.CategoryTypes categoryType)
        {
            return GetWatchesCommon(filterModel, categoryType);
        }

        public List<MediaPageListBaseModel> GetMediaPageListForCrawling(MediaPageCommonFilterModel filterModel)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                return col.Find(predicate).Select(x=> new MediaPageListBaseModel(x)).OrderBy(x => x.Path).ToList();
            }
        }

        public string GetMarkup(string id)
        {
            string result;

            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var pageMarkup = col.Find(x=> x.Id.Equals(id)).Select(x=>x.PageMarkup).FirstOrDefault();

                result = pageMarkup ?? string.Empty;
            }

            return result;
        }

        public bool UpdateMarkup(string pageId, string pageMarkup)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var aMediaPage = col.Find(x => x.Id.Equals(pageId)).FirstOrDefault();

                col.EnsureIndex(x => x.Id, true);
                
                if (aMediaPage != null)
                {
                    aMediaPage.PageMarkup = pageMarkup;
                    aMediaPage.IsCrawled = true;

                    col.Update(aMediaPage);

                    return true;
                }

                return false;
            }
        }

        public string GetInitialExcelFileName(MediaPageFilterModel filteringModel, ListensModel.CategoryTypes categoryType)
        {
            var filePrefix = FileNameSolver.GetListenInitialExcelFileName(categoryType);

            return GetInitialExcelFileName(filteringModel, filePrefix);
        }

        public string GetInitialExcelFileName(MediaPageFilterModel filteringModel, WatchesModel.CategoryTypes categoryType)
        {
            var filePrefix = FileNameSolver.GetWatchInitialExcelFileName(categoryType);

            return GetInitialExcelFileName(filteringModel, filePrefix);
        }

        public string GetInitialExcelFileName(MediaPageFilterModel filteringModel, string filePrefix)
        {
            var filename = new StringBuilder(filePrefix);

            if (filteringModel == null)
            {
                filename.Append("t-");
                filename.Append(DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss"));

                return filename.ToString();
            }

            var year = filteringModel.Year;
            if (!string.IsNullOrEmpty(year))
            {
                filename.Append($"{year}-");
            }

            var month = filteringModel.Month;
            if (!string.IsNullOrEmpty(month))
            {
                filename.Append($"{month}-");
            }

            var isCrawled = filteringModel.IsCrawled;
            if (isCrawled.HasValue)
            {
                filename.Append(isCrawled.Value 
                    ? "crawled-" 
                    : "not-crawled-");
            }

            filename.Append("t-");
            filename.Append(DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss"));

            return filename.ToString();
        }

        // For Adjustments/upgrades
        public bool MakeReadMediaType(string id)
        {
            bool result;

            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var aMediaPage = col.Find(x => x.Id.Equals(id)).FirstOrDefault();
                if (aMediaPage != null && string.IsNullOrEmpty(aMediaPage.MediaType))
                {
                    aMediaPage.MediaType = "Read";
                    col.Update(aMediaPage);

                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public MediaPageListResultDbModel GetMediaPages(MediaPageCommonFilterModel filterModel)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                var found = col.Find(predicate).ToList();

                var crawledCount = found.Count(x => x.IsCrawled);
                var notCrawledCount = found.Count(x => !x.IsCrawled);


                //var categories = found.GroupBy(x => x.Category).Select(x => x.Key);

                var pages = found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();

                return new MediaPageListResultDbModel
                {
                    Pages = pages,
                    Total = pages.Count,
                    Crawled = crawledCount,
                    NotCrawled = notCrawledCount
                };
            }
        }

        public MediaPagesTotalsReturnModel GetTotals()
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var found = col.FindAll().ToList();
                var crawledCount = found.Count(x => x.IsCrawled);
                var nonCrawledCount = found.Count(x => !x.IsCrawled);
                var count = found.Count();
                var readPagesCount = found.Count(x => x.MediaType == Consts.MediaTypes.Read);
                var listenPagesCount = found.Count(x => x.MediaType == Consts.MediaTypes.Listen);
                var watchPagesCount = found.Count(x => x.MediaType == Consts.MediaTypes.Watch);

                var foundRead = col.Find(x => x.MediaType == Consts.MediaTypes.Read).ToList();
                var crawledCountRead = foundRead.Count(x => x.IsCrawled);
                var nonCrawledCountRead = foundRead.Count(x => !x.IsCrawled);
                var countRead = foundRead.Count();
                var readArticlesCount = foundRead.Count(x => x.ArticleType == Consts.Articles.Article);
                var readMyDevotionalsCount = foundRead.Count(x => x.ArticleType == Consts.Articles.MyDevotional);
                var readMyJournalsCount = foundRead.Count(x => x.ArticleType == Consts.Articles.MyJournal);
                var readPrayersCount = foundRead.Count(x => x.ArticleType == Consts.Articles.Prayer);

                var foundListen = col.Find(x => x.MediaType == Consts.MediaTypes.Listen).ToList();
                var crawledCountListen = foundListen.Count(x => x.IsCrawled);
                var nonCrawledCountListen = foundListen.Count(x => !x.IsCrawled);
                var countListen = foundListen.Count();
                var listenEventsCount = foundListen.Count(x => x.Category == Consts.Listens.Events);
                var listenInterviewsCount = foundListen.Count(x => x.Category == Consts.Listens.Interviews);
                var listenSpecialBroadcastsCount = foundListen.Count(x => x.Category == Consts.Listens.SpecialBroadcasts);
                var listenTeachingCount = foundListen.Count(x => x.Category == Consts.Listens.Teaching);
                var listenUnCategorizedCount = foundListen.Count(x => x.Category == Consts.Listens.UnCategorized);

                var foundWatch = col.Find(x => x.MediaType == Consts.MediaTypes.Watch).ToList();
                var crawledCountWatch = foundWatch.Count(x => x.IsCrawled);
                var nonCrawledCountWatch = foundWatch.Count(x => !x.IsCrawled);
                var countWatch = foundWatch.Count();
                var watchEventsCount = foundWatch.Count(x => x.Category == Consts.Watches.Events);
                var watchInterviewsCount = foundWatch.Count(x => x.Category == Consts.Watches.Interviews);
                var watchSpecialBroadcastsCount = foundWatch.Count(x => x.Category == Consts.Watches.SpecialBroadcasts);
                var watchTeachingCount = foundWatch.Count(x => x.Category == Consts.Watches.Teaching);
                var watchTestimonialsCount = foundWatch.Count(x => x.Category == Consts.Watches.Testimonials);
                var watchUnCategorizedCount = foundWatch.Count(x => x.Category == Consts.Watches.UnCategorized);
                var watchVideoCount = foundWatch.Count(x => x.Category == Consts.Watches.Video);

                return new MediaPagesTotalsReturnModel
                {
                    ReadPagesCount = readPagesCount,
                    ListenPagesCount = listenPagesCount,
                    WatchPagesCount = watchPagesCount,
                    CrawledCount = crawledCount,
                    NonCrawledCount = nonCrawledCount,
                    Count = count,
                    ReadTotals = new ReadTotalsReturnModel(readArticlesCount, readMyDevotionalsCount, readMyJournalsCount, 
                                                            readPrayersCount, countRead, crawledCountRead, nonCrawledCountRead),
                    ListenTotals = new ListenTotalsReturnModel(listenEventsCount, listenInterviewsCount, listenSpecialBroadcastsCount, 
                                                            listenTeachingCount, listenUnCategorizedCount, countListen, crawledCountListen, nonCrawledCountListen),
                    WatchTotals = new WatchTotalsReturnModel(watchEventsCount, watchInterviewsCount, watchSpecialBroadcastsCount, 
                                                                watchTeachingCount, watchTestimonialsCount, watchUnCategorizedCount, watchVideoCount,
                                                                countWatch, crawledCountWatch, nonCrawledCountWatch)
                };
            }
        }

        #endregion Public Methods

        #region Private Methods

        private string CorrectUrlProtocol(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return string.Empty;
            }

            if (url.StartsWith("//"))
            {
                return url.Replace("//", "https://");
            }

            return url;
        }

        private string CorrectPath(MediaPageModel model, string year, string month)
        {
            if (model.Category.Equals(Consts.Articles.ArticlesCategory))
            {
                if (model.ArticleType.Equals(Consts.Articles.MyDevotional) && model.Path.StartsWith(Consts.Paths.MyDevotionalPath))
                {
                    return CorrectPathWithYearMonth(model.Path, Consts.Paths.MyDevotionalPath, year, month);
                }

                if (model.ArticleType.Equals(Consts.Articles.MyJournal) || model.ArticleType.Equals(Consts.Articles.Article) || (model.ArticleType.Equals(Consts.Articles.MyDevotional) && model.Path.StartsWith(Consts.Paths.ArticlesPath)))
                {
                    return CorrectPathWithYearMonth(model.Path, Consts.Paths.ArticlesPath, year, month);
                }

                if (model.ArticleType.Equals(Consts.Articles.Prayer))
                {
                    return model.Path.Replace(Consts.Paths.PrayerPath, string.Empty).Replace("/", "-");
                }
            }

            return model.Path;
        }

        private string CorrectPathWithYearMonth(string path, string replacementTarget, string year, string month)
        {
            var shortenPath = path.Replace(replacementTarget, string.Empty);

            var pathArray = shortenPath.Split('/');

            var pureName = pathArray[2];

            var result = $"{year}-{month}-{pureName.ToLower()}";

            return result.Replace("/", "-");
        }

        private string CorrectUrl(string url)
        {
            return url.Replace(Consts.Urls.UatHome, Consts.Urls.ProdHome);
        }

        private bool ExtendMediaPage(MediaPagesDbModel aMediaPage, MediaPagesDbModel model)
        {
            var isUpdated = false;

            var newUrl = model.Url ?? string.Empty;
            if (!newUrl.Equals(aMediaPage.Url))
            {
                aMediaPage.Url = newUrl;
                isUpdated = true;
            }

            var newPath = model.Path ?? string.Empty;
            if (!newPath.Equals(aMediaPage.Path))
            {
                aMediaPage.Path = newPath;
                isUpdated = true;
            }

            var newPageTitle = model.PageTitle ?? string.Empty;
            if (!newPageTitle.Equals(aMediaPage.PageTitle))
            {
                aMediaPage.PageTitle = newPageTitle;
                isUpdated = true;
            }

            var newPostedDate = model.PostedDate ?? string.Empty;
            if (!newPostedDate.Equals(aMediaPage.PostedDate))
            {
                aMediaPage.PostedDate = newPostedDate;
                isUpdated = true;
            }

            var newArticleType = model.ArticleType ?? string.Empty;
            if (!newArticleType.Equals(aMediaPage.ArticleType))
            {
                aMediaPage.ArticleType = newArticleType;
                isUpdated = true;
            }

            var newYear = model.Year ?? string.Empty;
            if (!newYear.Equals(aMediaPage.Year))
            {
                aMediaPage.Year = newYear;
                isUpdated = true;
            }

            var newMonth = model.Month ?? string.Empty;
            if (!newMonth.Equals(aMediaPage.Month))
            {
                aMediaPage.Month = newMonth;
                isUpdated = true;
            }

            var newDay = model.Day ?? string.Empty;
            if (!newDay.Equals(aMediaPage.Day))
            {
                aMediaPage.Day = newDay;
                isUpdated = true;
            }

            var newOpenGraphPageTitle = model.OpenGraphPageTitle ?? string.Empty;
            if (!string.IsNullOrEmpty(newOpenGraphPageTitle) || !string.IsNullOrEmpty(aMediaPage.OpenGraphPageTitle))
            {
                if (!newOpenGraphPageTitle.Equals(aMediaPage.OpenGraphPageTitle))
                {
                    aMediaPage.OpenGraphPageTitle = newOpenGraphPageTitle;
                    isUpdated = true;
                }
            }

            var newOpenGraphDescription = model.OpenGraphDescription ?? string.Empty;
            if (!string.IsNullOrEmpty(newOpenGraphDescription) || !string.IsNullOrEmpty(aMediaPage.OpenGraphDescription))
            {
                if (!newOpenGraphDescription.Equals(aMediaPage.OpenGraphDescription))
                {
                    aMediaPage.OpenGraphDescription = newOpenGraphDescription;
                    isUpdated = true;
                }
            }

            var newMetaDescription = model.MetaDescription ?? string.Empty;
            if (!string.IsNullOrEmpty(newMetaDescription) || !string.IsNullOrEmpty(aMediaPage.MetaDescription))
            {
                if (!newMetaDescription.Equals(aMediaPage.MetaDescription))
                {
                    aMediaPage.MetaDescription = newMetaDescription;
                    isUpdated = true;
                }
            }

            var newOpenGraphImage = model.OpenGraphImage ?? string.Empty;
            if (!string.IsNullOrEmpty(newOpenGraphImage) || !string.IsNullOrEmpty(aMediaPage.OpenGraphImage))
            {
                if (!newOpenGraphImage.Equals(aMediaPage.OpenGraphImage))
                {
                    aMediaPage.OpenGraphImage = newOpenGraphImage;
                    isUpdated = true;
                }
            }

            var newDefaultTitle = model.DefaultTitle ?? string.Empty;
            if (!string.IsNullOrEmpty(newDefaultTitle) || !string.IsNullOrEmpty(aMediaPage.DefaultTitle))
            {
                if (!newDefaultTitle.Equals(aMediaPage.DefaultTitle))
                {
                    aMediaPage.DefaultTitle = newDefaultTitle;
                    isUpdated = true;
                }
            }

            var newScripture = model.Scripture ?? string.Empty;
            if (!string.IsNullOrEmpty(newScripture) || !string.IsNullOrEmpty(aMediaPage.Scripture))
            {
                if (!newScripture.Equals(aMediaPage.Scripture))
                {
                    aMediaPage.Scripture = newScripture;
                    isUpdated = true;
                }
            }

            var newShortDescription = model.ShortDescription ?? string.Empty;
            if (!string.IsNullOrEmpty(newShortDescription) || !string.IsNullOrEmpty(aMediaPage.ShortDescription))
            {
                if (!newShortDescription.Equals(aMediaPage.ShortDescription))
                {
                    aMediaPage.ShortDescription = newShortDescription;
                    isUpdated = true;
                }
            }

            var newTags = model.Tags ?? string.Empty;
            if (!string.IsNullOrEmpty(newTags) || !string.IsNullOrEmpty(aMediaPage.Tags))
            {
                if (!newTags.Equals(aMediaPage.Tags))
                {
                    aMediaPage.Tags = newTags;
                    isUpdated = true;
                }
            }

            var newImageUrl = model.ImageUrl ?? string.Empty;
            if (!string.IsNullOrEmpty(newImageUrl) || !string.IsNullOrEmpty(aMediaPage.ImageUrl))
            {
                if (!newImageUrl.Equals(aMediaPage.ImageUrl))
                {
                    aMediaPage.ImageUrl = newImageUrl;
                    isUpdated = true;
                }
            }

            var newCategory = model.Category ?? string.Empty;
            if (!string.IsNullOrEmpty(newCategory) || !string.IsNullOrEmpty(aMediaPage.Category))
            {
                if (!newCategory.Equals(aMediaPage.Category))
                {
                    aMediaPage.Category = newCategory;
                    isUpdated = true;
                }
            }

            var newTopic = model.Topic ?? string.Empty;
            if (!string.IsNullOrEmpty(newTopic) || !string.IsNullOrEmpty(aMediaPage.Topic))
            {
                if (!newTopic.Equals(aMediaPage.Topic))
                {
                    aMediaPage.Topic = newTopic;
                    isUpdated = true;
                }
            }

            var newMediaAuthor = model.MediaAuthor ?? string.Empty;
            if (!string.IsNullOrEmpty(newMediaAuthor) || !string.IsNullOrEmpty(aMediaPage.MediaAuthor))
            {
                if (!newMediaAuthor.Equals(aMediaPage.MediaAuthor))
                {
                    aMediaPage.MediaAuthor = newMediaAuthor;
                    isUpdated = true;
                }
            }

            var newDownloadUrl = model.DownloadUrl ?? string.Empty;
            if (!string.IsNullOrEmpty(newDownloadUrl) || !string.IsNullOrEmpty(aMediaPage.DownloadUrl))
            {
                if (!newDownloadUrl.Equals(aMediaPage.DownloadUrl))
                {
                    aMediaPage.DownloadUrl = newDownloadUrl;
                    isUpdated = true;
                }
            }

            var newPurchaseUrl = model.PurchaseUrl ?? string.Empty;
            if (!string.IsNullOrEmpty(newPurchaseUrl) || !string.IsNullOrEmpty(aMediaPage.PurchaseUrl))
            {
                if (!newPurchaseUrl.Equals(aMediaPage.PurchaseUrl))
                {
                    aMediaPage.PurchaseUrl = newPurchaseUrl;
                    isUpdated = true;
                }
            }

            var newMediaDescription = model.MediaDescription ?? string.Empty;
            if (!string.IsNullOrEmpty(newMediaDescription) || !string.IsNullOrEmpty(aMediaPage.MediaDescription))
            {
                if (!newMediaDescription.Equals(aMediaPage.MediaDescription))
                {
                    aMediaPage.MediaDescription = newMediaDescription;
                    isUpdated = true;
                }
            }

            var newContent = model.Content ?? string.Empty;
            if (!string.IsNullOrEmpty(newContent) || !string.IsNullOrEmpty(aMediaPage.Content))
            {
                if (!newContent.Equals(aMediaPage.Content))
                {
                    aMediaPage.Content = newContent;
                    isUpdated = true;
                }
            }

            var newPullQuote = model.PullQuote ?? string.Empty;
            if (!string.IsNullOrEmpty(newPullQuote) || !string.IsNullOrEmpty(aMediaPage.PullQuote))
            {
                if (!newPullQuote.Equals(aMediaPage.PullQuote))
                {
                    aMediaPage.PullQuote = newPullQuote;
                    isUpdated = true;
                }
            }

            var newAudioVideoUrl = model.AudioVideoUrl ?? string.Empty;
            if (!string.IsNullOrEmpty(newAudioVideoUrl) || !string.IsNullOrEmpty(aMediaPage.AudioVideoUrl))
            {
                if (!newAudioVideoUrl.Equals(aMediaPage.AudioVideoUrl))
                {
                    aMediaPage.AudioVideoUrl = newAudioVideoUrl;
                    isUpdated = true;
                }
            }

            var newAudioVideoSubtitlesUrl = model.AudioVideoSubtitlesUrl ?? string.Empty;
            if (!string.IsNullOrEmpty(newAudioVideoSubtitlesUrl) || !string.IsNullOrEmpty(aMediaPage.AudioVideoSubtitlesUrl))
            {
                if (!newAudioVideoSubtitlesUrl.Equals(aMediaPage.AudioVideoSubtitlesUrl))
                {
                    aMediaPage.AudioVideoSubtitlesUrl = newAudioVideoSubtitlesUrl;
                    isUpdated = true;
                }
            }

            var newChangeAudioVideoUrl = model.ChangeAudioVideoUrl ?? string.Empty;
            if (!string.IsNullOrEmpty(newChangeAudioVideoUrl) || !string.IsNullOrEmpty(aMediaPage.ChangeAudioVideoUrl))
            {
                if (!newChangeAudioVideoUrl.Equals(aMediaPage.ChangeAudioVideoUrl))
                {
                    aMediaPage.ChangeAudioVideoUrl = newChangeAudioVideoUrl;
                    isUpdated = true;
                }
            }

            return isUpdated;
        }

        private Expression<Func<MediaPagesDbModel, bool>> GetFiltersPredicate(MediaPageFilterModel filterModel)
        {
            var predicate = PredicateBuilder.True<MediaPagesDbModel>();

            var year = filterModel.Year;
            if (!string.IsNullOrEmpty(year))
            {
                predicate = predicate.And(x => x.Year.Equals(year));
            }

            var month = filterModel.Month;
            if (!string.IsNullOrEmpty(month))
            {
                predicate = predicate.And(x => x.Month.Equals(month));
            }

            var title = filterModel.PageTitle;
            if (!string.IsNullOrWhiteSpace(title))
            {
                predicate = predicate.And(x => x.PageTitle.Contains(title));
            }

            var isCrawled = filterModel.IsCrawled;
            if (isCrawled.HasValue)
            {
                predicate = predicate.And(x => x.IsCrawled == isCrawled.Value);
            }

            return predicate;
        }

        private Expression<Func<MediaPagesDbModel, bool>> GetFiltersPredicate(MediaPageCommonFilterModel filterModel)
        {
            var predicate = GetFiltersPredicate((MediaPageFilterModel)filterModel);

            var mediaType = filterModel.MediaType;
            if (!string.IsNullOrEmpty(mediaType))
            {
                predicate = predicate.And(x => x.MediaType.Equals(mediaType));
            }

            var articleType = filterModel.ArticleType;
            if (!string.IsNullOrEmpty(articleType))
            {
                predicate = predicate.And(x => x.ArticleType.Equals(articleType));
            }

            var category = filterModel.Category;
            if (!string.IsNullOrEmpty(category))
            {
                predicate = predicate.And(x => x.Category.Equals(category));
            }

            return predicate;
        }

        private List<MediaPagesDbModel> GetArticlesCommon(MediaPageFilterModel filterModel, Consts.Articles.ArticleTypes articleType)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                predicate = predicate.And(x => x.Category == Consts.Articles.ArticlesCategory);

                predicate = predicate.And(x => x.ArticleType == FieldValueSolver.GetArticleTypeFieldValue(articleType));

                var found = col.Find(predicate).ToList();

                return found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();
            }
        }

        private MediaPageListResultModel GetArticlesLightCommon(MediaPageFilterModel filterModel, Consts.Articles.ArticleTypes articleType)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                predicate = predicate.And(x => x.Category == Consts.Articles.ArticlesCategory);

                predicate = predicate.And(x => x.ArticleType == FieldValueSolver.GetArticleTypeFieldValue(articleType));

                var found = col.Find(predicate).Select(x => new MediaPageListModel(x)).ToList();

                var crawledCount = found.Count(x => x.IsCrawled);
                var notCrawledCount = found.Count(x => !x.IsCrawled);

                var pages = found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();

                return new MediaPageListResultModel
                {
                    Pages = pages,
                    Total = pages.Count,
                    Crawled = crawledCount,
                    NotCrawled = notCrawledCount
                };
            }
        }

        private MediaPageListResultModel GetListensLightCommon(MediaPageFilterModel filterModel, ListensModel.CategoryTypes categoryType)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                predicate = predicate.And(x => x.MediaType == Consts.MediaTypes.Listen);

                predicate = categoryType != ListensModel.CategoryTypes.UnCategorized 
                    ? predicate.And(x => x.Category == FieldValueSolver.GetListenCategoryFieldValue(categoryType)) 
                    : predicate.And(x => x.Category == null);

                var found = col.Find(predicate).Select(x => new MediaPageListModel(x)).ToList();

                var crawledCount = found.Count(x => x.IsCrawled);
                var notCrawledCount = found.Count(x => !x.IsCrawled);

                var pages = found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();

                return new MediaPageListResultModel
                {
                    Pages = pages,
                    Total = pages.Count,
                    Crawled = crawledCount,
                    NotCrawled = notCrawledCount
                };
            }
        }

        private List<MediaPagesDbModel> GetListensCommon(MediaPageFilterModel filterModel, ListensModel.CategoryTypes categoryType)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                predicate = predicate.And(x => x.MediaType == Consts.MediaTypes.Listen);

                predicate = categoryType != ListensModel.CategoryTypes.UnCategorized
                    ? predicate.And(x => x.Category == FieldValueSolver.GetListenCategoryFieldValue(categoryType))
                    : predicate.And(x => x.Category == null);

                var found = col.Find(predicate).ToList();

                return found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();
            }
        }

        private MediaPageListResultModel GetWatchesLightCommon(MediaPageFilterModel filterModel, WatchesModel.CategoryTypes categoryType)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                predicate = predicate.And(x => x.MediaType == Consts.MediaTypes.Watch);

                predicate = categoryType != WatchesModel.CategoryTypes.UnCategorized
                    ? predicate.And(x => x.Category == FieldValueSolver.GetWatchCategoryFieldValue(categoryType))
                    : predicate.And(x => x.Category == null);

                var found = col.Find(predicate).Select(x => new MediaPageListModel(x)).ToList();

                var crawledCount = found.Count(x => x.IsCrawled);
                var notCrawledCount = found.Count(x => !x.IsCrawled);

                var pages = found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();

                return new MediaPageListResultModel
                {
                    Pages = pages,
                    Total = pages.Count,
                    Crawled = crawledCount,
                    NotCrawled = notCrawledCount
                };
            }
        }

        private List<MediaPagesDbModel> GetWatchesCommon(MediaPageFilterModel filterModel, WatchesModel.CategoryTypes categoryType)
        {
            using (var db = new LiteDatabase(Consts.Db.Name))
            {
                var col = db.GetCollection<MediaPagesDbModel>(Consts.Db.MediaPages);

                var predicate = GetFiltersPredicate(filterModel);

                predicate = predicate.And(x => x.MediaType == Consts.MediaTypes.Watch);

                predicate = categoryType != WatchesModel.CategoryTypes.UnCategorized
                    ? predicate.And(x => x.Category == FieldValueSolver.GetWatchCategoryFieldValue(categoryType))
                    : predicate.And(x => x.Category == null);

                var found = col.Find(predicate).ToList();

                return found.OrderBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Day).ToList();
            }

        }

        #endregion Private Methods
    }
}
