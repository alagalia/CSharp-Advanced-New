using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<char> first = input[0].ToList();
            List<char> second = input[1].ToList();
            var result = first.Zip(second, (a, b) => (a * b));
            int sum = result.Sum();
            if (first.Count() > second.Count())
            {
                int additionalSum = first.Skip(second.Count).Select(e => (int)e).Sum();
                sum += additionalSum;
            }
            else if (first.Count() < second.Count())
            {
                int additionalSum = second.Skip(first.Count).Select(e => (int)e).Sum();
                sum += additionalSum;
            }
                Console.WriteLine(sum);
        }
    }
}
