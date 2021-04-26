using System;
using System.ComponentModel.DataAnnotations;

namespace MuckScraperMVCApp.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        public string Title { get; set; }
        public string Subtitle { get; set; }

        public string SourceMedium { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }
        //TODO: Consolidate first name and last name into one field.

        public string SourceUrl { get; set; }

        public string PublicationName { get; set; }

        public DateTime UploadDate { get; set; }

        public DateTime PublishDate { get; set; }
        public string Content { get; set; }
        public string AddContent { get; set; }
    }
}
