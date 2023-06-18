using System;
using System.Collections.Generic;

namespace ConsoleAppLearning
{
    public class Homework8
    {

        public static void Main()
        {
            Student student1 = new Student("Bob", "Dylan", 21, "Kyiv");
            Student student2 = new Student("Ringo", "Star", 22, "Lviv");

            Course course1 = new Course("Physics", "Mr. Einstein");
            Course course2 = new Course("Math", "Mr. Escalante");

            student1.AddCourse(course1);
            student1.AddCourse(course2);
            student2.AddCourse(course2);

            course1.AddStudent(student1);
            course2.AddStudent(student1);
            course2.AddStudent(student2);

            Teacher teacher1 = new Teacher("Mr. Albert", "Einstein");
            Teacher teacher2 = new Teacher("Mr. Jaime", "Escalante");

            teacher1.AddStudent(student1);
            teacher1.AddStudent(student2);
            teacher2.AddStudent(student2);

            teacher1.AddCourse(course1);
            teacher2.AddCourse(course2);

            Console.WriteLine("All Students:");
            foreach (Student student in new List<Student> { student1, student2 })
            {
                student.DescribeYourself();
                Console.WriteLine("Courses Attended:");
                var courses = student.CoursesAttended.Select(c => $"{c.CourseName} with {c.TeacherName}");
                foreach (string course in courses)
                {
                    Console.WriteLine($"- {course}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("All Teachers:");
            foreach (Teacher teacher in new List<Teacher> { teacher1, teacher2 })
            {
                teacher.DescribeYourself();
                Console.WriteLine("Courses Taught:");
                var courses = teacher.CourseTaught.Select(x => x.CourseName);
                foreach (string course in courses)
                {
                    Console.WriteLine($"- {course}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("All Courses:");
            foreach (Course course in new List<Course> { course1, course2 })
            {
                Console.WriteLine($"Course: {course.CourseName}");
                Console.WriteLine($"Teacher: {course.TeacherName}");
                Console.WriteLine("Students:");
                var students = course.Students.Select(s => $"{s.FirstName} {s.LastName}");
                foreach (string student in students)
                {
                    Console.WriteLine($"- {student}");
                }
                Console.WriteLine();
            }

        }
    }
}