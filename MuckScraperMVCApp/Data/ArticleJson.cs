using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuckScraperMVCApp.Data
{
    public class ArticleJson
    {
        public string url { get; set; }
        public string? website_url { get; set; }
        public string? author { get; set; }
        public DateTime? date_published { get; set; }
        public string? lead_image_url { get; set; }
        public string? language { get; set; }
        public string? excerpt { get; set; }
        public string? title_1 { get; set; }
        public string? title_2 { get; set; }
        public string? content_1 { get; set; }
        public string? content_2 { get; set; }
    }
}
