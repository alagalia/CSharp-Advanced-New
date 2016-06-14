namespace _04.FindEvensorOdds
{
    using System;
    using System.Collections.Generic;
    public class FindEvensorOdds
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long start = long.Parse(input[0]);
            long end = long.Parse(input[1]);
            string command = Console.ReadLine().Trim().ToLower();

            List<long> resultOdd = new List<long>();
            List<long> resultEven = new List<long>();

            Func<long, bool> isOdd = i => i % 2 != 0;
            for (long i = start; i <= end; i++)
            {
                if (isOdd(i))
                {
                   resultOdd.Add(i); 
                }
                else
                {
                    resultEven.Add(i);
                }
            }

            List<long> result = command == "odd" ? resultOdd : resultEven;

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
