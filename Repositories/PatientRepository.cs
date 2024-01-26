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
    public class PatientRepository : IPatientRepository
    {
        private PatientContext _context;
        public PatientRepository(PatientContext context)
        {
            _context = context;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatientByName(string patientname)
        {
            return _context.Patients.SingleOrDefault(c => c.FullName == patientname);
        }
    }
}
