using Assignment01_EF_Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EF_Core.Classes
{


    //1 to m between this class and and student calss
    //1 to m between this class and and Course calss
    public class Stud_Course
    {
        // Foreign Key => Student
        [ForeignKey(nameof(Student))]
        public int Stud_ID { get; set; }
        public virtual Student Student { get; set; }

        // Foreign Key => Course
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public virtual Course Course { get; set; }

        // Extra column
        public string Evaluate { get; set; }


    }
}
