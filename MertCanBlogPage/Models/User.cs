using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MertCanBlogPage.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please, type in your name!")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please, type in your name between 2 and 20 characters!")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please, type in your surname!.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Please, type in your surname between 2 and 20 characters!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please,type in your email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please,type in your email with a valid format!")]
        public string Email { get; set; }

        [DataType(DataType.Url, ErrorMessage = "Please type in your web site in appropriate format.")]
        public string WebSite { get; set; }

        [DataType(DataType.ImageUrl, ErrorMessage = "Please, type in your image location correctly.")]
        public string ImagePath { get; set; }


        [Required(ErrorMessage = "Please type in membership date ")]
        [DataType(DataType.DateTime, ErrorMessage = "Please type in membership date correctly!")]
        public DateTime MembershipDate { get; set; }

        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please type in your Password !")]
        public string Password { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}