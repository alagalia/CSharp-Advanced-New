namespace _17.LegoBlock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using System.Text.RegularExpressions;

    public class LegoBlock
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[][] left = new string[n][];
            string[][] right = new string[n][];
            int blocks = 0;

            for (int row = 0; row < n; row++)
            {
                left[row] = Regex.Split(Console.ReadLine().Trim(), @"\s+");
                blocks += left[row].Length;
            }

            for (int row = 0; row < n; row++)
            {
                right[row] = Regex.Split(Console.ReadLine().Trim(), @"\s+");
                blocks += right[row].Length;
            }

            if (HasFit(left, right))
            {
                for (int i = 0; i < n; i++)
                {
                    PrintLine(left[i], right[i]);
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: " + blocks);
            }
        }

        private static void PrintLine(string[] left, string[] right)
        {
            List<string> leftList = new List<string>(left);
            var line = leftList.Concat(right.Reverse()).ToArray();
            Console.WriteLine("[" + string.Join(", ", line) + "]");
        }

        private static bool HasFit(string[][] left, string[][] right)
        {
            int lenght = left[0].Length + right[0].Length;
            for (int i = 1; i < left.Length; i++)
            {
                if (left[i].Length + right[i].Length != lenght)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
