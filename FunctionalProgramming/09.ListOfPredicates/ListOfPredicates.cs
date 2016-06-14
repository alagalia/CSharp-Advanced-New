namespace _09.ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> line = Console.ReadLine().Split().Select(int.Parse).ToList();
            HashSet<int> input = new HashSet<int>(line);

            Func<int, int, bool> isDivisible = (baseInt, divider) => baseInt % divider == 0;
            List<int> resul = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isValid = true;
                foreach (int num in input)
                {
                    if (!isDivisible(i, num))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    resul.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", resul));
        }
    }
}
