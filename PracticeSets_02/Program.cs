using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void LineGeneration()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            /*Console.WriteLine("Hello there! Please select a number:");
            Console.WriteLine("1. Odd Numbers");
            Console.WriteLine("2. Sum of the Digits");
            Console.WriteLine("3. Sum Array You Are!");
            Console.WriteLine("4. DNA BA ITO OR DSA LITE?");
            Console.WriteLine("5. Exit");*/

            while (true)
            {
                var Intro = new Intro();
                Intro.Intro1();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var Odd = new Odd();
                        Odd.Oddball();
                        break;

                    case 2:
                        var SumDigit = new SumDigit();
                        SumDigit.SumDigit1();
                        break;

                    case 3:
                        var SumArray = new SumArray();
                        SumArray.Sum_Array();
                        break;

                    case 4:
                        var DSA_lite = new DSA_lite();
                        DSA_lite.DSA_lite1();
                        break;
                    
                    case 5:
                        Console.WriteLine("Are you done? Yes or No?");
                        string answer = Console.ReadLine();
                        if (answer == "Yes")
                        {
                            Console.WriteLine("Goodbye!");
                            return;
                        }

                        else
                        {
                             continue;
                        }
                }
            }
        }
    }
}
