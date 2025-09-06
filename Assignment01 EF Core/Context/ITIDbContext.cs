using Assignment01_EF_Core.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_EF_Core.Context
{
    public class ITIDbContext:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
          =>  optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;").UseLazyLoadingProxies();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
          => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

       

        //DbSet for each class
        public DbSet<Student> Students { get; set; } //convert to table in data base 
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        //public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }




    }
}
