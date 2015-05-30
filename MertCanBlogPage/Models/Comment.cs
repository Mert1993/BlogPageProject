using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MertCanBlogPage.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [Required(ErrorMessage = "Please, enter your comment!")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please, enter the creation date of the comment!")]
        [DataType(DataType.DateTime, ErrorMessage = "Please, type in the creation date of the comment correctly!")]
        public DateTime Date { get; set; }

        public Article Article { get; set; }

        public User User { get; set; }
    }
}