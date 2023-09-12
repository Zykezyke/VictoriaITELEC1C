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
                InstructorId = 1, InsFirst = "Gabriel", InsLast = "Montano", HiringDate = DateTime.Parse("2022-08-26"), IsTenured = false, InstructorRank = Rank.Instructor
            },
            new Instructor()
            {
                InstructorId = 2, InsFirst = "Leo", InsLast = "Lintag", HiringDate = DateTime.Parse("2022-08-07"), IsTenured = true, InstructorRank = Rank.Professor
            },
            new Instructor()
            {
                InstructorId = 3, InsFirst = "Frederick", InsLast = "Rey", HiringDate = DateTime.Parse("2022-03-25"), IsTenured = false, InstructorRank = Rank.AssistantProfessor
            },
            new Instructor()
            {
                InstructorId = 4, InsFirst = "Eugenia", InsLast = "Zhuo", HiringDate = DateTime.Parse("2020-01-25"), IsTenured = true, InstructorRank = Rank.AssociateProfessor
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
    }
}
