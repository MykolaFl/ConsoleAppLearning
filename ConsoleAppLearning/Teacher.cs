using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public override void DescribeYourself() => Console.WriteLine($"I am a teacher from the {City} and I have {Students.Count} student(s) and {Courses.Count} course(s).");
    }
}
