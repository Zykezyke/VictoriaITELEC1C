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
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now, InstructorEmail="gdmontano@ust.edu.ph",InstructorRank = Rank.Instructor
            },
            new Instructor()
            {
                InstructorName = "Leo Lintag", DateHired = DateTime.Now, InstructorEmail="Llintag@ust.edu.ph",InstructorRank = Rank.AsstProf
            },
            new Instructor()
            {
                InstructorName = "Eugenia Zhuo", DateHired = DateTime.Now, InstructorEmail="erzhuo@ust.edu.ph",InstructorRank = Rank.Prof
            }

        };
        public IActionResult Index()
        {

            return View();
        }
    }
}
