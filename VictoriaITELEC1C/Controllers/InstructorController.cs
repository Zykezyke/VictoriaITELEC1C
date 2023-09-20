using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Models;

namespace VictoriaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorId = 1, InsFirst = "Gabriel", InsLast = "Montano", HiringDate = DateTime.Parse("2022-08-26"), IsTenured = false, InstructorRank = Rank.Instructor, InsPhone = "+639335557565", InsAdd = "276-279 San Jose Ext., Bgy. San Isidro Antipolo City"
            },
            new Instructor()
            {
                InstructorId = 2, InsFirst = "Leo", InsLast = "Lintag", HiringDate = DateTime.Parse("2022-08-07"), IsTenured = true, InstructorRank = Rank.Professor, InsPhone = "+63933227422", InsAdd = "J W S Center 731 Aurora Boulevard 1100 Quezon City"
            },
            new Instructor()
            {
                InstructorId = 3, InsFirst = "Frederick", InsLast = "Rey", HiringDate = DateTime.Parse("2022-03-25"), IsTenured = false, InstructorRank = Rank.AssistantProfessor, InsPhone = "+639827323910", InsAdd = "88 Capitol Hills Drive Matandang Balara Quezon City"
            },
            new Instructor()
            {
                InstructorId = 4, InsFirst = "Eugenia", InsLast = "Zhuo", HiringDate = DateTime.Parse("2020-01-25"), IsTenured = true, InstructorRank = Rank.AssociateProfessor, InsPhone = "+639202838482", InsAdd = "G/F El Nino Apartelle140 N. Domingo Cubao 1109 Quezon City"
            }

        };

        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

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
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.InstructorId == instructorChanges.InstructorId);

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
            return View("Index", InstructorList);
        }
    }
}
