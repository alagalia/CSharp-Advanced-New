namespace _02.SetsOfElements
{
    using System;
    using System.Collections.Generic;

    class SetsOfElements
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0].Trim());
            int m = int.Parse(input[1].Trim());
            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setN.Add(num);
            }

            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                setM.Add(num);
            }

            setN.IntersectWith(setM);
            foreach (int i in setN)
            {
                Console.WriteLine(i);
            }
        }
    }
}
