using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Teacher : Person
    {
        public string Subject { get; set; }


        public Teacher(string firstName, string lastName, int age, string city, string subject)
            : base(firstName, lastName, age, city)
        {
            LastName = lastName;
            FirstName = firstName;
            Subject = subject;
        }

        public override void DescribeYourself() => Console.WriteLine($"Teacher Name: {FirstName} {LastName}, Subject: {Subject}");
    }
}
