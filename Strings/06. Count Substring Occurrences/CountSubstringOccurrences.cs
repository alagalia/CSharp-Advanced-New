using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Count_Substring_Occurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string forSearch = Console.ReadLine().ToLower();
            int poss = input.IndexOf(forSearch);
            int counter = 0;
            while (poss >= 0 && poss <= input.Length)
            {
                counter++;
                poss = input.IndexOf(forSearch, poss + 1);

            }
            Console.WriteLine(counter);
        }
    }
}
