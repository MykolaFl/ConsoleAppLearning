using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Student : Person
    {
        public string[] CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city)
            : this(firstName, lastName, age, city, new string[0])
        {
        }

        public Student(string firstName, string lastName, int age, string city, string[] coursesAttended)
            : base(firstName, lastName, age, city)
        {
            CoursesAttended = coursesAttended;
        }

        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine("Courses Attended:");
            foreach (var course in CoursesAttended)
            {
                Console.WriteLine(course);
            }
        }

        public void AddCourse(string courseName)
        {
            int newLength = CoursesAttended.Length + 1;
            string[] updatedCourses = new string[newLength];
            for (int i = 0; i < CoursesAttended.Length; i++)
            {
                updatedCourses[i] = CoursesAttended[i];
            }
            updatedCourses[newLength - 1] = courseName;
            CoursesAttended = updatedCourses;
        }

        public void DeleteCourse(string courseName)
        {
            int index = Array.IndexOf(CoursesAttended, courseName);
            if (index < 0)
                return;

            int newLength = CoursesAttended.Length - 1;
            string[] updatedCourses = new string[newLength];
            for (int i = 0, j = 0; i < CoursesAttended.Length; i++)
            {
                if (i != index)
                {
                    updatedCourses[j] = CoursesAttended[i];
                    j++;
                }
            }
            CoursesAttended = updatedCourses;
        }

    }
}
