namespace _07.Arrange_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Arrange_Integers
    {
        static void Main()
        {
            int[] n = Console.ReadLine().Split(',').Select(num => num.Trim()).Select(int.Parse).ToArray();
            List<string> numbersAsString = n.Select(Parsed).ToList();
            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            for (int i = 0; i < n.Length; i++)
            {
                if (!dic.ContainsKey(numbersAsString[i]))
                {
                    dic.Add(numbersAsString[i], n[i]);
                }
            }

            List<string> sortedNumbersAsString = numbersAsString.OrderBy(str => str).ToList();
            List<int> result = sortedNumbersAsString.Select(str => dic[str]).ToList();
            Console.WriteLine(string.Join(", ", result));
        }

        private static string Parsed(int n)
        {
            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string numAsString = n.ToString();
            List<string> result = new List<string>();
            for (int i = 0; i < numAsString.Length; i++)
            {
                string num = unitsMap[int.Parse(numAsString[i].ToString())];
                result.Add(num);
            }

            return string.Join("-", result);
        }
    }
}
