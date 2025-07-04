using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Department { get; set; }
        public DateTime EnrolledDate { get; set; }
    }
}
