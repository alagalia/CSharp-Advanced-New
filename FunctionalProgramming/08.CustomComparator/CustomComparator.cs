namespace _08.CustomComparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Mycomparator
    {
        public static int Compare(int num1, int num2)
        {
            if (num1 % 2 != 0 && num2 % 2 == 0)
            {
                return 1;
            }

            if (num1 % 2 == 0 && num2 % 2 != 0)
            {
                return -1;
            }

            if (num1 > num2)
            {
                return 1;
            }

            if (num1 < num2)
            {
                return -1;
            }

            return 0;
        }
    }

    public class CustomComparator
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort(Mycomparator.Compare);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
