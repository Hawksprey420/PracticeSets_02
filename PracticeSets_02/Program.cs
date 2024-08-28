using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine(" Enter a Word: ");
                string Palindrome = Console.ReadLine();
                string check = new string(Palindrome.Reverse().ToArray());

                if (Palindrome.Contains(check))
                {
                    Console.WriteLine("The Word " + Palindrome + " is Palindrome ");
                }
                else if (Palindrome.Contains(check))
                {
                    Console.WriteLine("The Word" + Palindrome + " is not Palindrome ");
                }
                else
                {
                    Console.WriteLine("The Word" + Palindrome + " is Invalid ");
                }
            }
        }
    }
}
