using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using eHealth.Models;
using eHealth.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eHealth.Controllers
{
    public class PatientsController : Controller
    {
        private IPatientRepository _repository;
        private IWebHostEnvironment _environment;
        public PatientsController(IPatientRepository repository, IWebHostEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_repository.GetPatients());
        }

        public IActionResult ShowDataForPatient(string patientname)
        {
            var patient = _repository.GetPatientByName(patientname);
            if(patient == null) { return NotFound(); }
            return View(patient);
        }

        public IActionResult GetImage(string patientname)
        {
            return File($@"img\{patientname}.jpg", "img/jpeg") ;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
