using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace eHealth.Models
{
    public class Doctor : User
    {


        [Required(ErrorMessage = "Please enter an INAMI number")]
        [Display(Name = "INAMI")]
        public string inami {  get; set; }
    }
}
