using System.ComponentModel.DataAnnotations;
namespace ModelsDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Id is required")]
        [Display(Name = "Student Id")]
        public int StudId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Student Name")]
        [MaxLength(40, ErrorMessage = "Name must have less than 40 characters")]
        [MinLength(2)]
        public string? Name { get; set; }
        

        [Required(ErrorMessage ="Branch is required")]
       public string? Branch { get; set; }

        [Required(ErrorMessage ="City is required")]
        public string? City { get; set; }
        [Required]
        [Range(10,40)]
        public int Age { get; set; }

        [Required]

       public double? Percentage { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password does not match")]
        [DataType(DataType.Password)]

        public string? ConfirmPassword { get; set; }
    }
}
