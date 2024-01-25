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
    public class DoctorsController : Controller
    {
        private IDoctorRepository _repository;
        private IWebHostEnvironment _environment;
        public DoctorsController(IDoctorRepository repository, IWebHostEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_repository.GetDoctors());
        }

        public IActionResult Details(int id)
        {
            var doctor = _repository.GetDoctorById(id);
            if(doctor == null) { return NotFound(); }
            return View(doctor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreatePost(Doctor doctor)
        {
            if(ModelState.IsValid)
            {
                _repository.CreateDoctor(doctor);
                return RedirectToAction(nameof(Index));
            }
            return View(doctor);
        }

        [HttpGet]
        public IActionResult Modify(int id)
        {
            Doctor doctor = _repository.GetDoctorById(id);
            if(doctor == null) { return NotFound(id); }
            return View(doctor);
        }
    }
}
