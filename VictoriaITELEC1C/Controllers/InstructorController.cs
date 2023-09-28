using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Models;
using VictoriaITELEC1C.Services;

namespace VictoriaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorDummy _dummyData;

        public InstructorController(IInstructorDummy dummyData)
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {

            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            _dummyData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == instructorChanges.InstructorId);

            if (instructor != null)
            {
                instructor.InsFirst = instructorChanges.InsFirst;
                instructor.InsLast = instructorChanges.InsLast;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.InsPhone = instructorChanges.InsPhone;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.IsTenured    = instructorChanges.IsTenured;
                instructor.InsAdd = instructor.InsAdd;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor deleteIns)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == deleteIns.InstructorId);

            if (instructor != null)
            {
                _dummyData.InstructorList.Remove(instructor);
            }
            return RedirectToAction("Index");
        }

    }
}
