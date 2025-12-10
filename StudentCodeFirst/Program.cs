using System;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
            context.Database.EnsureCreated();

            var student = new Student();
            student.StudentName = "John Smith";
            student.DateOfBirth = new DateTime(2000, 5, 15);
            student.Height = 5.8M;
            student.Weight = 150.5F;

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully!");
            Console.WriteLine("Student ID: " + student.StudentId);
            Console.WriteLine("Name: " + student.StudentName);

            context.Dispose();
        }
    }
}