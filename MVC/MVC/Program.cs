using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

using (var context = new MyContext())
{
    // Create and save new Students
    Console.WriteLine("Adding new students");

    var student = new Student
    {
        FirstMidName = "Atyia",
        LastName = "Alam",
        EnrollmentDate = DateTime.Today,
        EmailAddress = "atyia.alam@example.com" // Added EmailAddress field
    };

    context.Students.Add(student);

    var student1 = new Student
    {
        FirstMidName = "Ali",
        LastName = "Ahmed",
        EnrollmentDate = DateTime.Today,
        EmailAddress = "ali.ahmed@example.com" // Added EmailAddress field
    };

    context.Students.Add(student1);
    context.SaveChanges();

    // Display all Students from the database
    var students = context.Students.OrderBy(s => s.FirstMidName).ToList();

    Console.WriteLine("Retrieve all Students from the database:");

    foreach (var stdnt in students)
    {
        string name = stdnt.FirstMidName + " " + stdnt.LastName;
        Console.WriteLine("ID: {0}, Name: {1}, Email: {2}", stdnt.ID, name, stdnt.EmailAddress);
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

public enum Grade
{
    A, B, C, D, F
}

public class Enrollment
{
    [Key]
    public int EnrollmentID { get; set; }

    [ForeignKey("Course")]
    public int CourseID { get; set; }

    [ForeignKey("Student")]
    public int StudentID { get; set; }

    public Grade? Grade { get; set; }

    public virtual Course Course { get; set; }
    public virtual Student Student { get; set; }
}

public class Student
{
    [Key]
    public int ID { get; set; }

    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public string EmailAddress { get; set; } // Added EmailAddress field

    public virtual ICollection<Enrollment> Enrollments { get; set; }
}

public class Course
{
    [Key]
    public int CourseID { get; set; }

    public string Title { get; set; }
    public int Credits { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; }
}

public class MyContext : DbContext
{
    public virtual DbSet<Course> Courses { get; set; }
    public virtual DbSet<Enrollment> Enrollments { get; set; }
    public virtual DbSet<Student> Students { get; set; }
}
