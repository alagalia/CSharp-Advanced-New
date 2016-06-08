namespace _03.CustomMinFunction
{
    using System;
    using System.Linq;
    class MinFunction
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            int[] nums = line.Select(int.Parse).ToArray();

            Func<int[], int> minNum = ints => ints.Min();
            Console.WriteLine(minNum(nums));
        }
    }
}
