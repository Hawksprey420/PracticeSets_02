using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //5. Write a program that takes a string as input and outputs the frequency of each character in the string. 

            Console.WriteLine("Please type in a word.");

            string word = Console.ReadLine();

            Console.WriteLine(word);  

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
}
