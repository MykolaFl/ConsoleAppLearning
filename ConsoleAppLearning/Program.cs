using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppLearning
{
    public class Homework4
    {

        public static void Main()
        {
            int mValue = FindMax(11, 7, 19);
            Console.WriteLine("The largest value from three integer values: " + mValue);
            Console.WriteLine("------------------------------------------");

            int miValue = FindMin(11, 7, 19);
            Console.WriteLine("The lowest value from three integer values: " + miValue);
            Console.WriteLine("------------------------------------------");

            int[] numbers = { 2, 4, 6, 8, 5 };
            int sum = ComputeTheSumAnArray(numbers);
            Console.WriteLine("The sum of all the elements of an array of integers: " + sum);
            Console.WriteLine("------------------------------------------");

            var array2 = new int[] { 4, 5, 22, 11, 7 };
            int maxvalue = LargeValueFromArray(array2);
            Console.WriteLine("The larger value from array - " + maxvalue);

        }
        public static int FindMax(int a, int b, int c) 
        {
            int maxValue = a;

            if (b > maxValue) 
                maxValue = b;

            if (c > maxValue)
                maxValue = c;
            
            return maxValue;
        }
        public static int FindMin(int a, int b, int c)
        {
            int minValue = a;

            if (b < minValue)
                minValue = b;

            if (c < minValue)
                minValue = c;

            return minValue;
        }

        public static int ComputeTheSumAnArray(int [] array)
        {
        int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                sum += array[i];
            }    
            return sum;
        }
        public static int LargeValueFromArray(int[] array2)
        {
            return array2.Max();
        }
    }
}