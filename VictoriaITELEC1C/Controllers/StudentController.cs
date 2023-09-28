using Microsoft.AspNetCore.Mvc;
using VictoriaITELEC1C.Models;
using VictoriaITELEC1C.Services;

namespace VictoriaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentDummy _dummyData;

        public StudentController(IStudentDummy dummyData)
        {
            _dummyData = dummyData;
        }
        public IActionResult Index()
        {

            return View(_dummyData.StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateStudent(int id) {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == studentChanges.Id);

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
            }
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student delStudent)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == delStudent.Id);
            if (student != null)
            {
                _dummyData.StudentList.Remove(student);
            }
            return RedirectToAction("Index");
        }
    }
}