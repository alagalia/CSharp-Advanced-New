namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            Stack<int> nums2 = new Stack<int>();
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (line == "2") 
                {
                    int currentNum = nums.Pop();
                    if (currentNum == max)
                    {
                        nums2.Pop();
                        max = nums2.Count == 0 ? 0 : nums2.Peek();
                    }
                }
                else if (line == "3")
                {
                    Console.WriteLine(max);
                }
                else 
                {
                    int num = int.Parse(line.Split(' ')[1]);
                    nums.Push(num);
                    if (num >= max)
                    {
                        nums2.Push(num);
                        max = num;
                    }
                }
            }
        }
    }
}
