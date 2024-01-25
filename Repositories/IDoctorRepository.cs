using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eHealth.Models;

namespace eHealth.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctorById(int id);
        void CreateDoctor(Doctor doctor);
        void DeleteDoctor(int id);

        void SaveChanges();

    }
}
