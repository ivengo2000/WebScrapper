using System.Net;

namespace WebScrapper.Models
{
    public class SendRequestReturnModel
    {
        public HttpStatusCode StatusCode { get; set; }

        public string StatusCodeText { get; set; }

        public string Url { get; set; }
    }
}
