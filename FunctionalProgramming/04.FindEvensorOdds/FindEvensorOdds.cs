namespace _04.FindEvensorOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FindEvensorOdds
    {
        public static void Main()
        {
            Func<long, long, string, List<long>> findEvensorOdds = (startNum, endNum, str) =>
                {
                    List<long> resultOdd = new List<long>();
                    List<long> resultEven = new List<long>();
                    for (long i = startNum; i <= endNum; i++)
                    {
                        if (i % 2 == 0)
                        {
                            resultEven.Add(i);
                        }
                        else
                        {
                            resultOdd.Add(i);
                        }
                    }

                    if (str == "odd")
                    {
                        return resultOdd;
                    }

                    if (str == "even")
                    {
                        return resultEven;
                    }

                    return new List<long>();
                };

            long[] inputNums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long start = inputNums[0];
            long end = inputNums[1];
            string command = Console.ReadLine();

            List<long> result = findEvensorOdds(start, end, command);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
