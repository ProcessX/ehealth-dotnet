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
      
    }
}
