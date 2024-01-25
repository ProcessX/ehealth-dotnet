using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eHealth.Models;

namespace eHealth.Models
{
    public interface IData
    {
        List<Doctor> doctors { get; set; }
        List<Doctor> doctorsInitializeData();
        Doctor getDoctorById(int? id);
    }
}
