using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment01_EF_Core.Classes;

namespace Assignment01_EF_Core.Classes
{
    public class Topic
    {
        //[Key]
        public int ID { get; set; }
        public string Name { get; set; }



        public virtual Course Course { get; set; } //nav prop 
    }
}
