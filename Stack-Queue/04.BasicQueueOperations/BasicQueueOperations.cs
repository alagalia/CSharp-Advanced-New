using System;
using System.Collections.Generic;


namespace _04.BasicQueueOperations
{
    using System.Linq;

    class BasicQueueOperations
    {
        static void Main()
        {
            int[] args = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Queue<int> numsQueue = new Queue<int>();
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < args[0]; i++)
            {
                numsQueue.Enqueue(nums[i]);
            }

            for (int i = 0; i < args[1]; i++)
            {
                numsQueue.Dequeue();
            }

            if (numsQueue.Contains(args[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                int result = numsQueue.Count == 0 ? 0 : numsQueue.Min();
                Console.WriteLine(result);
            }

        }
    }
}
