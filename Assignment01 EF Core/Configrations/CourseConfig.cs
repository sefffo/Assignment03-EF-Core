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
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> C)
        {
            C.HasKey(c => c.ID);
            //C.Property(c => c.ID).UseIdentityColumn(1, 1);
            C.Property(c => c.Name).IsRequired()
                                   .HasMaxLength(70)
                                   .HasColumnName("Topic Name");




            C.HasOne(c=>c.Topic)//each course has one topic
                .WithOne(t => t.Course)//each topic has one course 
                .HasForeignKey<Course>(c=>c.Top_ID) //the foreign key is found in topic table 
                .OnDelete(DeleteBehavior.Cascade);

                


        }

     
    }
}
