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

            /*Console.WriteLine("Let's print the odd numbers");
            int odd_number = 20;
            for (int i = 1; i < odd_number; i += 2)
            {
                Console.WriteLine(i);
            }*/

            while (true)
            {
                var Intro = new Intro();
                Intro.Intro1();
            }

        }
    }
}
