using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapper.Models
{
    public class MediaPageListResultDbModel: MediaPageListResultModelBase
    {
        public List<MediaPagesDbModel> Pages { get; set; }
    }
}
