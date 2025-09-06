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
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        public decimal? Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }


        [InverseProperty(nameof(Department.Instructors))]
        public virtual Department Department { get; set; }//nav prop 

        public int Dept_ID { get; set; } //table 




    }
}
