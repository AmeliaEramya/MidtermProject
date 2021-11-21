using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [_18YearsValidation]
        public DateTime DateOfBirth { get; set; }


        [Required]
        public int CourseId { get; set; }
        [Required]
        public DateTime CourseEnrolledDate { get; set; }
        [Required]
        public int CourseStatus { get; set; }
        
        [Required]
        [Range(1,10)]
        public string Grade { get; set; }
    }    
}
