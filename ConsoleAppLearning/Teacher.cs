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
        public List<Course> CourseTaught { get; set; }


        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Students = new List<Student>();
            CourseTaught = new List<Course>();

        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void AddCourse(Course course)
        {
            CourseTaught.Add(course);
        }
    }
}
