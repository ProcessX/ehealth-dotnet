using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eHealth.Data;
using eHealth.Models;

namespace eHealth.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private DoctorContext _context;
        public DoctorRepository(DoctorContext context)
        {
            _context = context;
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();
        }

        public Doctor GetDoctorById(int id)
        {
            return _context.Doctors.SingleOrDefault(d => d.id == id);
        }

        public void CreateDoctor(Doctor doctor)
        {
            if (doctor.profilePicture != null && doctor.profilePicture.Length > 0) {
                doctor.imageMimeType = doctor.profilePicture.ContentType;
                doctor.imageName = Path.GetFileName(doctor.profilePicture.FileName);
                using (var memoryStream = new MemoryStream())
                {
                    doctor.profilePicture.CopyTo(memoryStream);
                    doctor.imageFile = memoryStream.ToArray();
                }
            }
            _context.Add(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.Doctors.SingleOrDefault(d => d.id == id);
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        /*
        public async Task<bool> ModifyDoctor(Doctor doctor)
        {
            var doctorToUpdate = _context.Doctors.SingleOrDefault(d => d.id == doctor.id);
            doctorToUpdate.firstName = doctor.firstName;
            _context.Update(doctorToUpdate);
            var result = await _context.SaveChangesAsync();
            return false;
        }
        */
    }
}
