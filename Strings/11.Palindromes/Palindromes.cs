
namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;

    using System.Text.RegularExpressions;

    public class Palindromes
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            string line = Console.ReadLine();
            string[] words = Regex.Split(line, @"\W+");

            List<string> sortedOutput = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                string reversed = Reverse(words[i]);
                bool isnotEmpty = words[i] != String.Empty;
                if (isnotEmpty && words[i] == reversed)
                {
                    sortedOutput.Add(words[i]);
                }
            }

            sortedOutput.Sort();
            string result = "[" + string.Join(", ", sortedOutput) + "]";
            Console.WriteLine(result);
        }
    }
}
