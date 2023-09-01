using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Models;

namespace VictoriaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Zyke R. Victoria";
            st.DateEnrolled = DateTime.Parse("08/30/2023");
            st.StudentCourse = Course.BSIT;
            st.Email = "zyke.victoria.cics@ust.edu.ph";

            ViewBag.student = st;
            return View();
        }
    }
}
