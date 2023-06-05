using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string[] CoursesAttended { get; private set; }

        public Student(string firstName, string lastName, int age, string city)
            : this(firstName, lastName, age, city, new string[0])
        {
        }

        public Student(string firstName, string lastName, int age, string city, string[] coursesAttended)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            CoursesAttended = coursesAttended;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"City: {City}");
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
