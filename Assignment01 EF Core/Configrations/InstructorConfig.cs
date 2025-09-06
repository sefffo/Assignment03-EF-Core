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
    internal class InstructorConfig: IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> I)
        {
            I.HasKey(i => i.ID);
            I.Property(i=>i.ID).UseIdentityColumn(10,10);





            I.HasOne(i=>i.Department)
                .WithMany(d=>d.Instructors)
                .HasForeignKey(d=>d.Dept_ID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
