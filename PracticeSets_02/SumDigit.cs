using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    internal class SumDigit
    {
        public static void SumDigit1 ()
        {
            //6. Write a program that takes a number as input and outputs the sum of its digits.
            Console.WriteLine("Enter a number, preferably 3 or more digits please");

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your initial number is {number}");

            int sum1 = 0;
            int last_digit = 0;

            while (number > 0)
            {
                last_digit = number % 10;
                sum1 += last_digit;
                number /= 10;
            }
            Console.WriteLine($"Your final sum is {sum1}");
        }
    }
}
