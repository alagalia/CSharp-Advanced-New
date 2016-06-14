namespace _13.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];

            HashSet<char> firstSet = new HashSet<char>(first.ToCharArray());
            HashSet<char> secondSet = new HashSet<char>(second.ToCharArray());
            Console.WriteLine(firstSet.Count != secondSet.Count ? "false" : "true");
        }
    }
}
