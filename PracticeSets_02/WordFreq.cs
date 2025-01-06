using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    internal class WordFreq
    {
        public static void WordFreq1 ()
        {
            Console.WriteLine("Please type in a word.");
            string word = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            Console.WriteLine("Character frequencies:");
            foreach (var entry in frequency)
            {
                Console.WriteLine($"'{entry.Key}': {entry.Value}");
            }
        }
    }
}
