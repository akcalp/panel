using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace panel.Models
{
    public class Course
    {
        [Key]

        public int CourseId { get; set; }

        [Column(TypeName = "nvarchar(250)")]

        [Required]

        public string CourseName { get; set; }

        [Column(TypeName = "varchar(10)")]

        public int CourseCredit{ get; set; }

    }
}
