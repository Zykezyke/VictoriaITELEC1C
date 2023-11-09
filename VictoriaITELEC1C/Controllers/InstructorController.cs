using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Data;
using VictoriaITELEC1C.Models;

namespace VictoriaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbData;

        public InstructorController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

        [Authorize]
        public IActionResult Index()
        {

            return View(_dbData.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            if(!ModelState.IsValid)
                return View();

            _dbData.Instructors.Add(newInstructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == instructorChanges.InstructorId);

            if (instructor != null)
            {
                instructor.InsFirst = instructorChanges.InsFirst;
                instructor.InsLast = instructorChanges.InsLast;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.InsPhone = instructorChanges.InsPhone;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.IsTenured    = instructorChanges.IsTenured;
                instructor.InsAdd = instructor.InsAdd;
                _dbData.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor deleteIns)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == deleteIns.InstructorId);

            if (instructor != null)
            {
                _dbData.Instructors.Remove(instructor);
                _dbData.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
