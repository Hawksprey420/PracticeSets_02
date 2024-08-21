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
            Console.WriteLine("Let's print the even numbers");
            int even_number = 22;

            for (int i = 2; i < even_number; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
