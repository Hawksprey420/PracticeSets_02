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
            Console.WriteLine("Let's print the odd numbers");
            int even_number = 20;

            for (int i = 1; i < even_number; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
