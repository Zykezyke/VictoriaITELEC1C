using System.ComponentModel.DataAnnotations;

namespace VictoriaITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter Your First Name")]
        public string InsFirst { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string InsLast { get; set; }

        [Display(Name = "IsTenured")]
        public Boolean IsTenured { get; set; }

        [Display(Name = "Rank")]
        public Rank InstructorRank { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Set A Date")]
        public DateTime? HiringDate { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please Enter Your Address")]
        public string InsAdd { get; set; }

        [Display(Name = "Phone Numbers")]
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string InsPhone { get; set; }

        [Display(Name = "Profile Picture")]
        public byte[]? InstructorPfp { get; set; }

    }
}
