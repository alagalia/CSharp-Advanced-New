namespace _09.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(',').ToList();
            input = input.Select(s => s.Trim()).ToList();

            string text = Console.ReadLine();

            input.ForEach(str => text = text.Replace(str, new string('*', str.Length)));

            Console.WriteLine(text);
        }
    }
}
