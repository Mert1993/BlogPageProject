using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MertCanBlogPage.Models
{
    public class Article
    {
        public int ArticleId { get; set; }

        [Required(ErrorMessage = "Please, type in the title of the article!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The title of the article must be between 3 to 50!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, type in the content of the article!")]
        [DataType(DataType.Html, ErrorMessage = "Please, type in the content of the article in html format!")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please, type in the addition date of the article!")]
        [DataType(DataType.DateTime, ErrorMessage = "Please, type in the addition of the title of the article correctly!")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please, type in the author of the article!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The author of the article must be between 3 to 50 characters!")]
        public string Author { get; set; }

        public User User { get; set; }
        // Bir makalede, birden fazla yorum bulunabilir veya etiket. Bir makaleyi yanlızca bir user yazabilir.
        public ICollection<Comment> Comments { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}