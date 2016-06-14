
namespace _06.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main(string[] args)
        {
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDivisable = (baseNum, divider) => baseNum % divider != 0;

            var result = line.Where(x => myFunc(x, n, isDivisable)).ToArray();
            Array.Reverse(result);
            Console.WriteLine(string.Join(" ", result));
        }

        public static bool myFunc(int baseInt, int divider, Func<int, int, bool> myFunc)
        {
            return myFunc(baseInt, divider);
        }
    }
}
