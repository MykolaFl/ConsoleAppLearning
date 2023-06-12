using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int Duration { get; set; }
        public int NumberOfStudents { get; set; }

        public Course(string courseName, string teacherName, int duration)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            Duration = duration;
            NumberOfStudents = 0;
        }

        public void AddStudent()
        {
            NumberOfStudents++;
        }

        public void RemoveStudent()
        {
            NumberOfStudents--;
        }

        public void Describe()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Teacher: {TeacherName}");
            Console.WriteLine($"Duration: {Duration} hour(s)");
            Console.WriteLine($"Number of Students: {NumberOfStudents}");
        }
    }
}
