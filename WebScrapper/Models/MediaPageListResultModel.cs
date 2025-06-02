using System.Collections.Generic;

namespace WebScrapper.Models
{
    public class MediaPageListResultModel: MediaPageListResultModelBase
    {
        public List<MediaPageListModel> Pages { get; set; }
    }
}
