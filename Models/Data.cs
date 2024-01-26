using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eHealth.Models;

namespace eHealth.Models
{
    public class Data : IData
    {
        public List<Doctor> doctors { get; set; }
        public List<Patient> patients { get; set; }

        public List<Doctor> doctorsInitializeData()
        {
            doctors = new List<Doctor>()
            {
                new Doctor(){
                    id = 1,
                    firstName = "Shawna",
                    lastName = "Trejo",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "7055" },
                new Doctor(){
                    id = 2,
                    firstName = "Rod",
                    lastName = "Hale",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "4478" },
                new Doctor(){
                    id = 3,
                    firstName = "Christopher",
                    lastName = "Green",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "588" } ,
                new Doctor(){
                    id = 4,
                    firstName = "Debra",
                    lastName = "Meyers",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "9077" } ,

            };

            return doctors;
        }
        public List<Patient> patientsInitializeData()
        {
            patients = new List<Patient>()
            {
                new Patient() {
                    id = 1, FullName= "Erling Haland", Age= 324, Description= "Description 01", BirthDate= "13/07/1994", Gender= "Homme", Contact= "0484666560", InsuranceNumber= "NI-8956", ChronicConditions= "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", PastMedicalHistory= "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", FamilyMedicalHistory= "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", Medications= "Medications text details pour mon patiet est = bla bla bla bla bla ...", SocialHistory= "Marié"},
                new Patient() {
                    id = 2, FullName= "Kilian Empapé", Age= 326, Description= "Description 02", BirthDate= "13/07/1994", Gender= "Homme", Contact= "0484666560", InsuranceNumber= "NI-8956", ChronicConditions= "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", PastMedicalHistory= "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", FamilyMedicalHistory= "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", Medications= "Medications text details pour mon patiet est = bla bla bla bla bla ...", SocialHistory= "Marié" },
                new Patient() {
                    id = 3, FullName= "Lionel Messi", Age= 34, Description= "Description 03", BirthDate= "13/07/1994", Gender= "Homme", Contact= "0484666560", InsuranceNumber= "NI-8956", ChronicConditions= "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", PastMedicalHistory= "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", FamilyMedicalHistory= "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", Medications= "Medications text details pour mon patiet est = bla bla bla bla bla ...", SocialHistory= "Marié" },
                new Patient() {
                    id = 4, FullName= "Cristiano Renaldo", Age= 38, Description= "Description 04", BirthDate= "13/07/1994", Gender= "Homme", Contact= "0484666560", InsuranceNumber= "NI-8956", ChronicConditions= "Chronic Conditions text details pour mon patiet est = bla bla bla bla bla ...", PastMedicalHistory= "Past Medical History text details pour mon patiet est = bla bla bla bla bla ...", FamilyMedicalHistory= "Family Medical History text details pour mon patiet est = bla bla bla bla bla ...", Medications= "Medications text details pour mon patiet est = bla bla bla bla bla ...", SocialHistory= "Marié"}
            };

            return patients;
        }

     

        public Doctor getDoctorById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return doctors.SingleOrDefault(a => a.id == id);
            }
        }
        public Patient GetPatientByName(string? patientname)
        {
            if (patientname == null)
            {
                return null;
            }
            else
            {
                return patients.SingleOrDefault(a => a.FullName == patientname);
            }
        }
      
    }
}
