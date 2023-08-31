using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}

class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
}

class StudentCourse
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { StudentId = 1, Name = "Alice" },
            new Student { StudentId = 2, Name = "Bob" },
            new Student { StudentId = 3, Name = "Carol" }
        };

        List<Course> courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Math" },
            new Course { CourseId = 102, CourseName = "Science" },
            new Course { CourseId = 103, CourseName = "History" }
        };

        List<StudentCourse> studentCourses = new List<StudentCourse>
        {
            new StudentCourse { StudentId = 1, CourseId = 101 },
            new StudentCourse { StudentId = 1, CourseId = 102 },
            new StudentCourse { StudentId = 2, CourseId = 101 },
            new StudentCourse { StudentId = 3, CourseId = 103 }
        };

        var query = from student in students
                    join sc in studentCourses on student.StudentId equals sc.StudentId
                    join course in courses on sc.CourseId equals course.CourseId
                    select new
                    {
                        student.Name,
                        course.CourseName
                    };

        foreach (var result in query)
        {
            Console.WriteLine($"Student: {result.Name}, Course: {result.CourseName}");
        }
    }
}

