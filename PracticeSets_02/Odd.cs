using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    internal class Odd
    {
        public static void Oddball ()
        {
            Console.WriteLine("Let's print the odd numbers");
            int odd_number = 20;
            for (int i = 1; i < odd_number; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
