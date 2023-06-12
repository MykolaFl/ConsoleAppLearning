using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    public class Homework7
    {

        public static void Main()
        {
            Student student1 = new Student("Bob", "Dylan", 21, "Kyiv");
            Student student2 = new Student("Ringo", "Star", 22, "Lviv");

            Teacher teacher = new Teacher("Albert", "Einstein", 45, "Berlin");

            Course course1 = new Course("Math", "Hlibov", 60);
            Course course2 = new Course("Physics", "Fedoriv", 50);

            teacher.Students.Add(student1);
            teacher.Students.Add(student2);

            course1.AddStudent();
            course2.AddStudent();

            student1.CoursesAttended.Add(course1);
            student1.CoursesAttended.Add(course2);
            student2.CoursesAttended.Add(course2);

            teacher.Courses.Add(course1);
            teacher.Courses.Add(course2);

            student1.DescribeYourself();
            Console.WriteLine();

            student2.DescribeYourself();
            Console.WriteLine();

            teacher.DescribeYourself();
            Console.WriteLine();

            course1.RemoveStudent();;

            course1.Describe();
            Console.WriteLine();

            course2.Describe();

        }
    }
}