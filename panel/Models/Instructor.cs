using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace panel.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string InstructorName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string InstructorEmail{ get; set; } 
      
    }
}
