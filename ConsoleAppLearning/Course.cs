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
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Course(string courseName, string teacherName)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
