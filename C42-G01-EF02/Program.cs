using C42_G01_EF02.Contexts;
using C42_G01_EF02.Entities;

namespace C42_G01_EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Syntax Sugar
            using ITIDbContext context = new ITIDbContext();



            #region Old Syntax
            //try
            //{
            //    // CRUD Operations
            //}
            //finally
            //{
            //    //[ Close || Free ] database connection 
            //} 
            #endregion

            // Create
            var Student01 = new Student
            {
                FirstName = "Ahmed",
                LastName = "Mohamed",
                Address = "123 Main Street",
                Age = 25,
                DepartmentId = 1
            };
            var Student02 = new Student
            {
                FirstName = "Ali",
                LastName = "Omir",
                Address = "123 Main Street",
                Age = 25,
                DepartmentId = 1
            };


            Console.WriteLine(context.Entry(Student01).State);
            context.Add(Student01);
            Console.WriteLine(context.Entry(Student01).State);
            context.SaveChanges();
            Console.WriteLine(context.Entry(Student01).State);
            Console.WriteLine("Student added: " + Student01.FirstName);

            // Read
            // Retrieve all students
            var students = context.Students.ToList();
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
            }

            // Retrieve a specific student by ID
            var studentToUpdate = context.Students.FirstOrDefault(s => s.Id == Student01.Id);
            if (studentToUpdate != null)
            {
                Console.WriteLine($"Found student: {studentToUpdate.FirstName} {studentToUpdate.LastName}");
            }

            // Update
            if (studentToUpdate != null)
            {
                studentToUpdate.Address = "456 Updated Street";
                Console.WriteLine(context.Entry(Student01).State);
                context.Update(studentToUpdate);
                Console.WriteLine(context.Entry(Student01).State);
                context.SaveChanges();
                Console.WriteLine(context.Entry(Student01).State);
                Console.WriteLine("Student updated: " + studentToUpdate.FirstName);
            }

            // Delete
            // Find the student to delete
            var studentToDelete = context.Students.FirstOrDefault(s => s.Id == Student01.Id);
            if (studentToDelete != null)
            {
                Console.WriteLine(context.Entry(Student01).State);
                context.Remove(studentToDelete);
                Console.WriteLine(context.Entry(Student01).State);
                context.SaveChanges();
                Console.WriteLine(context.Entry(Student01).State);
                Console.WriteLine("Student deleted: " + studentToDelete.FirstName);
            }





        }
    }
}
