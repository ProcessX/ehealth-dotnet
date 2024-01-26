using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace eHealth.Models
{
    public class Patient
    {
        public int id { get; set; }

        public string FullName { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string InsuranceNumber { get; set; }
        public string ChronicConditions { get; set; }
        public string PastMedicalHistory { get; set; }
        public string Medications { get; set; }
        public string FamilyMedicalHistory { get; set; }
        public string SocialHistory { get; set; }

        public Patient()
        {

        }
    }
}
