using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    internal class PS02_05
    {
        public static void PS02_05_Function()
        {
            {
                Console.WriteLine("Enter a character: ");
                char letter = char.Parse(Console.ReadLine());


                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    Console.WriteLine("is a vowel");
                }
                else if (letter == 'b' || letter == 'c' || letter == 'd' || letter == 'f' ||
                    letter == 'g' || letter == 'h' || letter == 'j' || letter == 'k' || letter == 'l' || letter == 'm' ||
                    letter == 'n' || letter == 'p' || letter == 'q' || letter == 'r' || letter == 's' || letter == 't' ||
                    letter == 'v' || letter == 'w' || letter == 'x' || letter == 'y' || letter == 'z')
                {
                    Console.WriteLine("is a consonant");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

            }
        }
    }
}
