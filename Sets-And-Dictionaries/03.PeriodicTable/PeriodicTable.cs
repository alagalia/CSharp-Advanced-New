namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    public class PeriodicTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string element in input)
                {
                    elements.Add(element);
                }
            }

            string allElements = String.Join(" ", elements);
            Console.WriteLine(allElements);
        }
    }
}
