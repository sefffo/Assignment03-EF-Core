using Assignment01_EF_Core.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EF_Core.Configrations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(s => s.ID);
            //S.Property(e => e.ID).UseIdentityColumn(1, 1); //auto increment
            S.Property(e => e.FName).IsRequired()
                                   .HasMaxLength(50)
                                   .HasColumnName("First Name"); //change column name in database
            S.Property(e => e.LName).IsRequired()
                                  .HasMaxLength(50)
                                  .HasColumnName("Last Name"); //change column name in database


           S.HasOne(s=>s.Department) // Student has one Department
                .WithMany(d=>d.Students)  // Department has many Student
                .HasForeignKey(s=>s.Dept_id) // Foreign Key in Student table
                .OnDelete(DeleteBehavior.Cascade); // Delete Student if Department deleted

        }
    }
}
