using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Homework5
    {

        public static void Main()
        {
            Student student = new Student("Mykola", "Hlibov", 18, "Kyiv");
            student.Print();

            Console.WriteLine();

            student.AddCourse("Math");
            student.Print();

            Console.WriteLine();

            student.DeleteCourse("Math");
            student.Print();

            Course course = new Course("English", "Ellyson Parker", 90);
            course.Print();

            Console.WriteLine();


            course.AddStudent();
            course.Print();

        }


    }
}