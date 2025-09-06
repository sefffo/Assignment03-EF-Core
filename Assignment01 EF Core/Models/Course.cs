using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment01_EF_Core.Classes;

namespace Assignment01_EF_Core.Classes
{
    public class Course
    {
        //[Key]
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        [ForeignKey("Topic ID")]
        public int Top_ID { get; set; }


        [InverseProperty("Course")]
        public virtual Topic Topic { get; set; } //nav prop 


        // Navigation property => Many-to-Many
        public virtual ICollection<Stud_Course> Stud_Courses { get; set; }


    }
}
