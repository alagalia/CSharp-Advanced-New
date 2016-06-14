namespace _10.UnicodeCharacters
{
    using System;
    using System.Linq;
    using System.Text;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToList();
            var result = new StringBuilder();
            input.ForEach(c => result.Append(GetEscapeSequence(c)));
            Console.WriteLine(result.ToString());
        }

        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4").ToLower();
        }
    }
}
