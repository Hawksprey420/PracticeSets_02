using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    internal class SumArray
    {
        public static void Sum_Array ()
        {
            // 7. Write a program that takes an array of numbers as input and outputs the sum of the numbers. 
            Console.WriteLine("Number of array? ");
            int number1 = int.Parse(Console.ReadLine());

            int sum = 0;

            int[] array = new int[number1];
            for (int i = 0; i < number1; i++)
            {
                Console.WriteLine("Enter a number: ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
