using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Student : Person
    {
        public int Age { get; set; }
        public string City { get; set; }
        public List<Course> CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            CoursesAttended = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            CoursesAttended.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            CoursesAttended.Remove(course);
        }

    }
}
