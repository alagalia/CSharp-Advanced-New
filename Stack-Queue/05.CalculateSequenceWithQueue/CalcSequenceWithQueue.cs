namespace _05.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    class CalcSequenceWithQueue
    {
        static void Main(string[] args)
        {
            long s = long.Parse(Console.ReadLine());
            Queue<long> myQueue = new Queue<long>();
            List<long> result = new List<long>();
            myQueue.Enqueue(s);
            result.Add(s);
            
            while (result.Count < 50)
            {
                long current = myQueue.Dequeue();

                myQueue.Enqueue(current + 1);
                myQueue.Enqueue((2 * current) + 1);
                myQueue.Enqueue(current + 2);

                result.Add(current + 1);
                result.Add((2 * current) + 1);
                result.Add(current + 2);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
