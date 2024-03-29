﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MuckScraperMVCApp.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        
        public int RequestId { get; set; }

        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string SourceMedium { get; set; }

        public string AuthorName { get; set; }

        public string SourceUrl { get; set; }

        public string PublicationName { get; set; }

        public DateTime UploadDate { get; set; }

        public DateTime PublishDate { get; set; }
        public string Content { get; set; }
        public string AddContent { get; set; }
        public string Image { get; set; }
    }
}
