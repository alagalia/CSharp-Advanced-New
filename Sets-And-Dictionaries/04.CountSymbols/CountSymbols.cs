namespace _04.CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbols
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();
            SortedDictionary<char, int> charoccurance = new SortedDictionary<char, int>();
            for (int i = 0; i < inputText.Length; i++)
            {
                char ch = inputText[i];
                if (!charoccurance.ContainsKey(ch))
                {
                    charoccurance.Add(ch, 0);
                }
                charoccurance[ch]++;
            }
            foreach (var kv in charoccurance)
            {
                Console.WriteLine("{0}: {1} time/s", kv.Key, kv.Value);
            }
        }
    }
}
