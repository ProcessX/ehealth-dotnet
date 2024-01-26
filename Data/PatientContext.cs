using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using eHealth.Models;
using Microsoft.EntityFrameworkCore;

namespace eHealth.Data
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options) : base(options) { }
        //public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient()
                 {
                     id = 1,
                     FullName = "Erling Haland",
                     Age = 324,
                     Description = "Description 01",
                     BirthDate = "13/07/1994",
                     Gender = "Homme",
                     Contact = "0484666560",
                     InsuranceNumber = "NI-8956",
                     ChronicConditions = "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...",
                     PastMedicalHistory = "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                     FamilyMedicalHistory = "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                     Medications = "Medications text details pour mon patiet est = bla bla bla bla bla ...",
                     SocialHistory = "Marié"
                 },
                new Patient()
                {
                    id = 2,
                    FullName = "Kilian Empapé",
                    Age = 326,
                    Description = "Description 02",
                    BirthDate = "13/07/1994",
                    Gender = "Homme",
                    Contact = "0484666560",
                    InsuranceNumber = "NI-8956",
                    ChronicConditions = "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...",
                    PastMedicalHistory = "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                    FamilyMedicalHistory = "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                    Medications = "Medications text details pour mon patiet est = bla bla bla bla bla ...",
                    SocialHistory = "Marié"
                },
                new Patient()
                {
                    id = 3,
                    FullName = "Lionel Messi",
                    Age = 34,
                    Description = "Description 03",
                    BirthDate = "13/07/1994",
                    Gender = "Homme",
                    Contact = "0484666560",
                    InsuranceNumber = "NI-8956",
                    ChronicConditions = "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...",
                    PastMedicalHistory = "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                    FamilyMedicalHistory = "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                    Medications = "Medications text details pour mon patiet est = bla bla bla bla bla ...",
                    SocialHistory = "Marié"
                },
                new Patient()
                {
                    id = 4,
                    FullName = "Cristiano Renaldo",
                    Age = 38,
                    Description = "Description 04",
                    BirthDate = "13/07/1994",
                    Gender = "Homme",
                    Contact = "0484666560",
                    InsuranceNumber = "NI-8956",
                    ChronicConditions = "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...",
                    PastMedicalHistory = "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                    FamilyMedicalHistory = "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...",
                    Medications = "Medications text details pour mon patiet est = bla bla bla bla bla ...",
                    SocialHistory = "Marié"
                }
 );
        }
    }
}
