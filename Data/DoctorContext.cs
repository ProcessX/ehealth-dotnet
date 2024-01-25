using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eHealth.Models;
using Microsoft.EntityFrameworkCore;

namespace eHealth.Data
{
    public class DoctorContext : DbContext
    {
        public DoctorContext(DbContextOptions<DoctorContext> options) : base(options) { }
        //public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor()
                {
                    id = 1,
                    firstName = "Shawna",
                    lastName = "Trejo",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "7055",
                    imageMimeType = "image/jpeg",
                    imageName = "shawna_trejo.jpg"
                },
                new Doctor()
                {
                    id = 2,
                    firstName = "Rod",
                    lastName = "Hale",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "4478",
                    imageMimeType = "image/jpeg",
                    imageName = "rod_hale.jpg"
                },
                new Doctor()
                {
                    id = 3,
                    firstName = "Christopher",
                    lastName = "Green",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "588",
                    imageMimeType = "image/jpeg",
                    imageName = "christopher_green.jpg"
                },
                new Doctor()
                {
                    id = 4,
                    firstName = "Debra",
                    lastName = "Meyers",
                    birthDate = DateOnly.FromDateTime(DateTime.Now),
                    inami = "9077",
                    imageMimeType = "image/jpeg",
                    imageName = "debra_meyer.jpg"
                }
                );
        }
    }
}
