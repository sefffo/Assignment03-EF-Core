using Assignment01_EF_Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EF_Core.Models
{
    [Table("Course_Insts")] // To match your DB table name
    public class Inst_Course
    {
        // Composite Key → Will be configured in Fluent API
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        [Required]
        public string Evaluate { get; set; }

        // Navigation Properties
        [ForeignKey(nameof(InstructorId))]
        public virtual Instructor Instructor { get; set; }

        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; }
    }
}
