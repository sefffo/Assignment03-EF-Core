using Assignment01_EF_Core.Classes;
using Assignment01_EF_Core.Context;
using Microsoft.EntityFrameworkCore;

namespace Assignment01_EF_Core
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            using ITIDbContext db = new ITIDbContext(); //unmanged Code
            //iTIDbContext.Database.GetPendingMigrations();//in production
            //var department = new Department
            //{
            //    Name = "CS",
            //    HiringDate = new DateTime()
            //};
            //db.Departments.Add(department);
            //db.SaveChanges();




            //Console.WriteLine("=== Adding a New Instructor ===");
            //var newInstructor = new Instructor
            //{
            //    Name = "Saif Lotfy",
            //    Salary = 12000,
            //    Bouns = 500,
            //    Adress = "Cairo",
            //    HourRate = 300,
            //    Dept_ID = 1 // Make sure this Department exists!
            //};

            //db.Instructors.Add(newInstructor);
            //db.SaveChanges();
            //Console.WriteLine($"Instructor Added: {newInstructor.Name} with ID = {newInstructor.ID}");

            //// ======== READ =========
            //Console.WriteLine("\n=== Retrieving All Instructors ===");
            //var instructors = db.Instructors.Include(i => i.Department).ToList();
            //foreach (var instructor in instructors)
            //{
            //    Console.WriteLine($"ID: {instructor.ID} | Name: {instructor.Name} | Dept: {instructor.Department?.Name}");
            //}

            //// ======== UPDATE =========
            //Console.WriteLine("\n=== Updating an Instructor ===");
            //var instructorToUpdate = db.Instructors.FirstOrDefault(i => i.ID == newInstructor.ID);
            //if (instructorToUpdate != null)
            //{
            //    instructorToUpdate.Salary = 15000;
            //    db.SaveChanges();
            //    Console.WriteLine($"Updated Instructor Salary: {instructorToUpdate.Name} → {instructorToUpdate.Salary}");
            //}
            //else
            //{
            //    Console.WriteLine("Instructor not found!");
            //}

            //// ======== DELETE =========
            //Console.WriteLine("\n=== Deleting an Instructor ===");
            //var instructorToDelete = db.Instructors.FirstOrDefault(i => i.ID == newInstructor.ID);
            //if (instructorToDelete != null)
            //{
            //    db.Instructors.Remove(instructorToDelete);
            //    db.SaveChanges();
            //    Console.WriteLine($"Instructor Deleted: {instructorToDelete.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("Instructor not found!");
            //}

            //Console.WriteLine("\n=== CRUD Operations Completed Successfully ===");



            #region loading -related data


            ///mmomkn nst5dm el nav props 
            ///

            //egar loading
            //var dept = db.Departments.Include(e => e.ID).FirstOrDefault(d => d.ID == 1);

            var dept = db.Departments.FirstOrDefault(d => d.ID == 1); //using proxies and lazy loading 

            //for the one in the relation
            //context.Entry<Department>(dept).Reference(e => e.ID).Load(); //

            //Console.WriteLine(dept.ID?.Name ?? "N/A");

            //for the many in the relation 
            //context.Entry<Department>(dept).Collection(e => e.employees).Load(); //


            foreach (var e in dept.Instructors)
            {
                Console.WriteLine(e.Name);
            }



            #endregion
        }

    }
    
}
