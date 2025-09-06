using Assignment01_EF_Core.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EF_Core.Configrations
{
    public class Stud_CourseConfig : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> SC)
        {
          SC.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });




            SC.HasOne(sc => sc.Student) //each studCorse Ref has one student
              .WithMany(s => s.Stud_Courses)//each student has many studCourse
              .HasForeignKey(s => s.Stud_ID)  // Foreign key in Stud_Course table is  Stud_ID
              .OnDelete(DeleteBehavior.Cascade);

            SC.HasOne(sc=>sc.Course) //each stud corse has one course 
                .WithMany(c=>c.Stud_Courses) //one course has many studcourse 
                .HasForeignKey(sc=>sc.Course_ID)// Foreign key in Stud_Course table is  Course_ID
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
