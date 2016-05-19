using System;
using System.Collections.Generic;

namespace Stacks
{
    public class StackExercise
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] nums = line.Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach (string num in nums)
            {
                stack.Push(num);
            }
            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
