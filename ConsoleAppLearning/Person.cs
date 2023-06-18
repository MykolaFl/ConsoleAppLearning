using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public  class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.");
        }
    }
}
