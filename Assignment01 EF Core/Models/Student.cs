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
    public class Student
    {
        //[Key]
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //nav props 
        //[ForeignKey(nameof(Department))] 
        public int Dept_id { get; set; }    //forign key coulmn 


        [InverseProperty(nameof(Department.Students))] 
        public virtual Department Department { get; set; }//nav prop 



        public virtual ICollection<Stud_Course> Stud_Courses { get; set; } //nav prop for many to many 


    }
}
