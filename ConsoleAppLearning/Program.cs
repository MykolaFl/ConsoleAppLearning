using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Homework5_6
    {

        public static void Main()
        {
            Student student = new Student("Mykola", "Hlibov", 18, "Kyiv");
            student.DescribeYourself();

            Console.WriteLine();

            student.AddCourse("Math");
            student.DescribeYourself();

            Console.WriteLine();

            student.DeleteCourse("Math");
            student.DescribeYourself();

            Console.WriteLine();

            Teacher teacher = new Teacher("Ellyson", "Parker", 55, "Lviv", "Physics");
            teacher.DescribeYourself();
            Console.WriteLine();

            Course course = new Course("Physics", "Ellyson Parker", 90);
            course.Print();

            Console.WriteLine();


            course.AddStudent();
            course.Print();

        }


    }
}