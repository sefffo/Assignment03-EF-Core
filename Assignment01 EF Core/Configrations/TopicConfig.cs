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
    internal class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> T)
        {


            T.HasKey(t=>t.ID);
            T.Property(t=>t.Name)
                .IsRequired()
                .HasMaxLength(100);






            T.HasOne(t => t.Course)//each topic has one course
               .WithOne(c => c.Topic)//each course has one topic 
               .HasForeignKey<Course>(c => c.Top_ID) //the foreign key is found in topic table 
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
