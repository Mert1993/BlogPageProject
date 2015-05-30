using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MertCanBlogPage.Models
{
    public class Tag
    {
        public int TagID { get; set; }

        [Required(ErrorMessage = "Please, type in the content of the tag!")]
        [StringLength(50, ErrorMessage = "The content of the tag must be lower than 50 characters!")]
        public String Content { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}