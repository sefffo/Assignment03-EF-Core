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
    internal class DeptConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> D)
        {
            D.HasKey(d => d.ID);

            D.Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Configure One-to-Many Relationship
            D.HasMany(d => d.Students)          // One Department has Many Students
             .WithOne(s => s.Department)       // Each Student belongs to one Department
             .HasForeignKey(s => s.Dept_id)    // Foreign Key in Student table
             .OnDelete(DeleteBehavior.Cascade); // If Department deleted → Delete Students
        }
    }
}
