using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace panel.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "nvarchar(250)")]

        [Required]

        public string StudentName { get; set; }

        [Column(TypeName = "varchar(10)")]

        public int StudentGPA { get; set; }
    }
}
