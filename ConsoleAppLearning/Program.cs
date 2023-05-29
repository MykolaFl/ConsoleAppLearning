using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Exercise6
    {
        public static void Main()
        {
            Console.WriteLine("Input a number(integer): ");
            int j = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;

            while (j != 0)
            {
                sum += j % 10;
                j /= 10;
            }

            Console.WriteLine("Sum of the digits of the said integer: " + sum);

        }
    }
}