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
using System.Diagnostics;

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

        [HttpPost, ActionName("Modify")]
        public async Task<IActionResult> ModifyPost(Doctor doctor)
        {
            var doctorToUpdate = _repository.GetDoctorById(doctor.id);

            bool isUpdated = await TryUpdateModelAsync<Doctor>(
                                    doctorToUpdate,
                                    "",
                                    d => d.firstName,
                                    d => d.lastName,
                                    d => d.inami,
                                    d => d.birthDate);
            /*
            if (isUpdated)
            {
                _repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            */

            try
            {
                _repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                return View(doctor);
            }


        }
        

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var doctor = _repository.GetDoctorById(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return View(doctor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.DeleteDoctor(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetImage(int id)
        {
            Doctor requestedDoctor = _repository.GetDoctorById(id);
            if (requestedDoctor != null)
            {
                string webRootpath = _environment.WebRootPath;
                string folderPath = "\\img\\";
                string fullPath = webRootpath + folderPath + requestedDoctor.imageName;
                if (System.IO.File.Exists(fullPath))
                {
                    FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);
                    byte[] fileBytes;
                    using (BinaryReader br = new BinaryReader(fileOnDisk))
                    {
                        fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                    }
                    return File(fileBytes, requestedDoctor.imageMimeType);
                }
                else
                {
                    if (requestedDoctor.imageFile.Length > 0)
                    {
                        return File(requestedDoctor.imageFile, requestedDoctor.imageMimeType);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            else
            {
                return NotFound();
            }
        }
    }
}
