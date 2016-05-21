

namespace _09.StackFibonacci
{
    using System;
    using System.Collections.Generic;

    class StackFibonacci
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> fib = new Stack<long>();
            fib.Push(1);
            fib.Push(1);
            long resultFib = 1;
            for (int i = 0; i < n - 2; i++)
            {
                long secondNum = fib.Pop();
                long firstNum = fib.Pop();
                resultFib = firstNum + secondNum;
                fib.Push(secondNum);
                fib.Push(resultFib);
            }

            Console.WriteLine(resultFib);
        }
    }
}
