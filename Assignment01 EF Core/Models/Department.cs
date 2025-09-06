using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment01_EF_Core.Classes;

namespace Assignment01_EF_Core.Classes
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        //navigation properties
                                                               //HashSet
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();//3hsan lazem y3ml refer l object (Mfhosh data  )

        //use hashshet to remove the repeated Elements 

        public virtual ICollection<Instructor> Instructors { get;   set; } = new List<Instructor>();


    }
}
