namespace _08.RecursiveFibonacci
{
    using System;
    using System.Collections.Generic;

    class RecursiveFibonacci
    {
        private static Dictionary<int, long> fibDictionary = new Dictionary<int, long>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long fib = GetFibonacci(n);
            Console.WriteLine(fib);
        }

        public static long GetFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }
            
            if (fibDictionary.ContainsKey(n))
            {
                return fibDictionary[n];
            }

            long current = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            fibDictionary.Add(n, current);
            return current;
        }
    }
}
