using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_11.DTO;
using APBD_11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APBD_11.Controllers
{
    [ApiController]
    [Route("/api/doctors")]
    public class DoctorsController : Controller
    {
        private readonly DoctorDbContext _context;

        public DoctorsController(DoctorDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            return Ok(_context.Doctors.ToList().Find(dr => id == dr.IdDoctor));
        }

        [HttpPost("add")]
        public IActionResult AddDoctor(DoctorModel doctor)
        {
            try
            {
                if (doctor != null)
                {
                    _context.Add(doctor);
                    _context.SaveChanges();
                    return Ok("saved");
                }

                return NotFound();
            }
            catch { return BadRequest(); }

        }
        [HttpPut("update")]
        public IActionResult UpdateDoctor(DoctorUpdateRequest request)
        {
            try
            {

                if (_context.Doctors.ToList().Count(dr => dr.IdDoctor == request.Id) > 0)
                {
                    var doctor = _context.Doctors.ToList().Find(dr => dr.IdDoctor == request.Id);

                    if (request.FirstName != null) doctor.FirstName = request.FirstName;
                    if (request.LastName != null) doctor.LastName = request.LastName;
                    if (request.Email != null) doctor.Email = request.Email;

                    _context.SaveChanges();
                    return Ok("Doctor number " + doctor.IdDoctor + " updated!");

                }

                return NotFound();
            }

            catch { return BadRequest(); }
          
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var doc = _context.Doctors.ToList().Find(dr => dr.IdDoctor == id);
            if (doc == null) return NotFound();
            _context.Doctors.Remove(doc);
            _context.SaveChanges();
            return Ok(id + "th doctor deleted!");
        }

    
    }
}