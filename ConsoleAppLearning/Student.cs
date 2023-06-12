using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Student : Person
    {
        public List<Course> CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            CoursesAttended = new List<Course> ();
        }

        public void AddCourse(Course course)
        {
            CoursesAttended.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            CoursesAttended.Remove(course);
        }
        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine($"I am a student and attended {CoursesAttended.Count} course(s).");
        }

    }
}
