using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Data;
using VictoriaITELEC1C.Models;

namespace VictoriaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbData;

        public StudentController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

        
        public IActionResult Index()
        {

            return View(_dbData.Students);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [Authorize]
        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            if (!ModelState.IsValid)
                return View();

            _dbData.Students.Add(newStudent);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateStudent(int id) {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == studentChanges.Id);

            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;
                student.Phone = studentChanges.Phone;
                student.Course = studentChanges.Course;
                student.Address = studentChanges.Address;
                student.AdmissionDate   = studentChanges.AdmissionDate;
                student.GPA = studentChanges.GPA;

                _dbData.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student delStudent)
        {
            Student? student = _dbData.Students.FirstOrDefault(st => st.Id == delStudent.Id);
            if (student != null)
            {
                _dbData.Students.Remove(student);
                _dbData.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}