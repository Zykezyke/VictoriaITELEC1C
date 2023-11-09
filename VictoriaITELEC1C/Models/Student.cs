using System.ComponentModel.DataAnnotations;

namespace VictoriaITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }

    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter Your First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string LastName { get; set; }
        [Display(Name = "GPA")]
        [Required(ErrorMessage = "Please Enter Your GPA")]
        public double? GPA { get; set; }
        [Display(Name = "Course")]
        [Required(ErrorMessage = "Please Select A Course")]
        public Course Course { get; set; }
        [Display(Name = "Admission Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Enter A Date")]
        public DateTime? AdmissionDate { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }
    }
}
