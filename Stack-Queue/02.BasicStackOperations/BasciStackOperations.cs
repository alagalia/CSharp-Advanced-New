namespace _02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasciStackOperations
    {
        static void Main()
        {
            string line = Console.ReadLine();
            int[] inputParams =
                line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int elementsPop = inputParams[1];
            int searchedElem = inputParams[2];
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            Stack<int> numStack = new Stack<int>(nums);
            for (int i = 0; i < elementsPop; i++)
            {
                numStack.Pop();
            }

            if (numStack.Contains(searchedElem))
            {
                Console.WriteLine("true");
            }
            else if(numStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numStack.ToArray().Min());
            }
        }
    }
}
