namespace _14.LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class LettersChangeNumbers
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(new string[] { " ", "\n", "\t" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            double sum = input.Sum(s => GetValue(s));
            Console.WriteLine("{0:F2}", sum);
        }

        private static double GetValue(string str)
        {
            double result = 0;
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(str);
            int num = int.Parse(match.Value);
            double leftLetter = char.ToLower(str.First()) - 96;
            double rightLetter = char.ToLower(str.Last()) - 96;
            if (char.IsUpper(str.First()))
            {
                result += num / leftLetter;
            }
            else
            {
                result += num * leftLetter;
            }

            if (char.IsUpper(str.Last()))
            {
                result = result - rightLetter;
            }
            else
            {
                result = result + rightLetter;
            }
            return result;
        }
    }
}
