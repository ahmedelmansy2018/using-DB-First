using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HopeUniversity.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    
    }
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime Date { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

    }

    public class HopeUniversityEntities : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }

}