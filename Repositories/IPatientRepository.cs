using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eHealth.Models;

namespace eHealth.Repositories
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatientByName(string patientname);
    }
}
