using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Models;

namespace VictoriaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Zyke",LastName = "Victoria", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "victoriazyke@gmail.com", Phone = "+639179873357", Address = "Block 3 Lot 6A San Lorenzo Ruiz Square, New Intramuros Village, Matandang Balara, Quezon City"
                },
                new Student()
                {
                    Id= 2,FirstName = "Mark",LastName = "Alicante", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "makiro08@gmail.com", Phone = "+639077208775", Address = "149 Bulusan Street La Loma 1100 Quezon City"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com", Phone = "+639942369454", Address = "237 Tandang Sora Avenue Quezon City"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

    }
}