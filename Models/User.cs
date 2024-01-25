using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;


namespace eHealth.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter a firstname")]
        [Display(Name = "Firstname")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Please enter a lastname")]
        [Display(Name = "Lastname")]
        public string lastName { get; set; }
        [Required(ErrorMessage = "Please select a birth date")]
        [Display(Name = "Birth date")]
        public DateOnly birthDate { get; set; }
        [NotMapped]
        [Display(Name = "Profile picture")]
        public IFormFile profilePicture { get; set; }
        public string imageName { get; set;}
        public byte[]? imageFile { get; set; }
        public string imageMimeType { get; set; }

        public User()
        {

        }

    }
}
