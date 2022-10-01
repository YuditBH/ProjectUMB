using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace UProject.ViewModuls
{
    public class ContactViewModul
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Your message must be 500 characters or less")]
        public string Message { get; set; }

        public int ContactFormId { get; set; }
    }
}