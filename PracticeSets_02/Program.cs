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
            while (true)
            {
                var Intro = new Intro();
                Intro.Intro1(); LineGeneration();
                int choice = int.Parse(Console.ReadLine());
                LineGeneration();
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
                        var PS02_05 = new PS02_05();
                        PS02_05.PS02_05_Function();
                        break;

                    case 6:
                        var PS02_06 = new PS02_06();
                        PS02_06.Palindrome();
                        break;

                    case 7:
                        var WordFreq = new WordFreq();
                        WordFreq.WordFreq1();
                        break;

                    case 8:
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
