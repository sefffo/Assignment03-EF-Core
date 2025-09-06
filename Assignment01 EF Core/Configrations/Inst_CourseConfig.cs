using Assignment01_EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EF_Core.Configrations
{
    internal class Inst_CourseConfig : IEntityTypeConfiguration<Inst_Course>
    {
        public void Configure(EntityTypeBuilder<Inst_Course> entity)
        {
            // Table Name
            entity.ToTable("Course_Insts");

            // Composite Primary Key
            entity.HasKey(ci => new { ci.InstructorId, ci.CourseId });

            // Relationships
            entity.HasOne(ci => ci.Instructor)
                  .WithMany() // If Instructor has no direct collection of courses
                  .HasForeignKey(ci => ci.InstructorId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(ci => ci.Course)
                  .WithMany() // If Course has no direct collection of instructors
                  .HasForeignKey(ci => ci.CourseId)
                  .OnDelete(DeleteBehavior.Cascade);

            // Column configuration
            entity.Property(ci => ci.Evaluate)
                  .IsRequired()
                  .HasMaxLength(250); // Optional constraint
        }
    }
}
