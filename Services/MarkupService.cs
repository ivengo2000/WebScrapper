using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CsQuery;
using WebScrapper.Models;

namespace WebScrapper.Services
{
    public class MarkupService
    {
        protected readonly HttpClient HttpClient;

        public MarkupService()
        {
            HttpClient = GetHttpClient();
        }

        #region Public Methods

        public static HttpClient GetHttpClient()
        {
            var client = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false });
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/json");
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required");

            return client;
        }

        public string GetMarkup(string requestUri)
        {
            var result = string.Empty;
            try
            {
                result = HttpClient.GetStringAsync(requestUri).Result;
            }
            catch (Exception e)
            {
                return result;
            }

            return result;
        }

        public SendRequestReturnModel SendRequest(string requestedPageText)
        {
            var result = new SendRequestReturnModel();

            //var theUrl = $"{RootUrl}/{requestedPageText.TrimStart('/')}";
            var theUrl = requestedPageText.Trim();

            var response = HttpClient.GetAsync(theUrl).Result;

            var targetUrl = string.Empty;

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    targetUrl = theUrl;
                    break;
                case HttpStatusCode.Redirect:
                case HttpStatusCode.MovedPermanently:
                case HttpStatusCode.RedirectKeepVerb:
                case HttpStatusCode.RedirectMethod:
                    targetUrl = response.Headers.Location.ToString();
                    break;
                case HttpStatusCode.NotFound:
                    targetUrl = string.Empty;
                    break;
            }

            result.StatusCodeText = ((int)response.StatusCode).ToString();
            result.StatusCode = response.StatusCode;
            result.Url = targetUrl;

            return result;
        }

        public string ProcessMarkup(string response, string selector)
        {
            var result = string.Empty;

            try
            {
                // Removing empty lines
                var cleanedUpMarkup = Regex.Replace(response, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);

                // Removing styles attribute
                cleanedUpMarkup = Regex.Replace(cleanedUpMarkup, @"<([^>]*)(\sstyle="".+?""(\s|))(.*?)>", "<$1$3>", RegexOptions.Multiline | RegexOptions.Compiled);

                // Removing of SCORE system attribute 'data-ux-args' (CsQuery doesn't remove it)
                cleanedUpMarkup = Regex.Replace(cleanedUpMarkup, @"<([^>]*)(\sdata-ux-args="".+?""(\s|))(.*?)>", "<$1$3>", RegexOptions.Multiline | RegexOptions.Compiled);

                var page = new CQ(cleanedUpMarkup);
                var foundObject = page[selector];

                // Removing of SCORE system attributes
                foundObject = foundObject.RemoveData();
                //.RemoveAttr("data-ux-module") 
                //.RemoveAttr("data-ux-state");

                foundObject.Find(".tags-component").Remove();
                foundObject.Find(".media-topic-title").Remove();
                foundObject.Find(".media-series-title ").Remove();
                foundObject.Find(".document-header").Remove();
                foundObject.Find(".author-component").Remove();
                foundObject.Find(".posted-date-component").Remove();
                foundObject.Find(".score-share-this-widget").Remove();
                foundObject.Find("img").Remove();

                result = foundObject.Children().RenderSelection();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);

                return result;
            }

            return result;
        }

        public string ProcessMyDevotionalMarkup(string response)
        {
            //return ProcessMarkup(response, ".page-wrapper.media-article > div.container.score-page-layout-column2.score-page-layout-large-left > div.score-column2.wide-left > div.score-left");
            return ProcessMarkup(response, "div.container.score-page-layout-column2.score-page-layout-large-left > div.score-column2.wide-left > div.score-left");
        }

        public Tuple<bool, string> RemoveTagsContent(string markup)
        {
            var foundObject = new CQ(markup);

            var tagsComponentMarkup = GetTagsContentMarkup(foundObject);

            if (!string.IsNullOrEmpty(tagsComponentMarkup))
            {
                var updatedMarkup = foundObject.RenderSelection().Replace(tagsComponentMarkup, string.Empty);

                return new Tuple<bool, string>(true, Regex.Replace(updatedMarkup, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline));
            }

            return new Tuple<bool, string>(false, foundObject.RenderSelection());
        }

        public Tuple<bool, string> RemoveMediaTopicTitleContent(string markup)
        {
            var foundObject = new CQ(markup);

            var mediaTopicComponentMarkup = GetMediaTopicTitleContentMarkup(foundObject);

            if (!string.IsNullOrEmpty(mediaTopicComponentMarkup))
            {
                var markupObj = new CQ("<div>" + foundObject.RenderSelection() + "</div>");
                markupObj.Find(".media-topic-title").Remove();
                markupObj.Find(".document-header").Remove();
                markupObj.Find(".author-component").Remove();
                markupObj.Find(".posted-date-component").Remove();
                markupObj.Find(".score-share-this-widget").Remove();

                return new Tuple<bool, string>(true, markupObj.Children().RenderSelection());
            }

            return new Tuple<bool, string>(false, foundObject.RenderSelection());
        }

        public Tuple<bool, string> RemoveImages(string markup)
        {
            var foundObject = new CQ(markup);

            var imagesCount = GetImagesCount(foundObject);
            if (imagesCount > 0)
            {
                var markupObj = new CQ("<div>" + foundObject.RenderSelection() + "</div>");
                markupObj.Find("img").Remove();

                return new Tuple<bool, string>(true, markupObj.Children().RenderSelection());
            }

            return new Tuple<bool, string>(false, foundObject.RenderSelection());
        }

        #endregion Public Methods

        #region Private Methods

        private string GetTagsContentMarkup(CQ foundObject)
        {
            var tagsComponent = foundObject[".tags-component"];

            return tagsComponent.RenderSelection();
        }

        private string GetMediaTopicTitleContentMarkup(CQ foundObject)
        {
            var mediaTopicTitleComponent = foundObject[".media-topic-title"];

            return mediaTopicTitleComponent.RenderSelection();
        }

        private int GetImagesCount(CQ foundObject)
        {
            var tagsComponent = foundObject["img"];

            return tagsComponent.Length;
        }

        #endregion Private Methods
    }
}
