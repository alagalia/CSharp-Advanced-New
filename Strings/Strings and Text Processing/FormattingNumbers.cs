namespace Strings_and_Text_Processing
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FormattingNumbers
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] input = Regex.Split(line, @"\s+").Select(x => x.Trim()).ToArray();
            long a = long.Parse(input[0]);
            double b = double.Parse(input[1], CultureInfo.InvariantCulture);
            double c = double.Parse(input[2], CultureInfo.InvariantCulture);

            string hex = a.ToString("X");
            string binary = Convert.ToString(a, 2);
            string result = "|" + hex.PadRight(10) + "|" + binary.PadLeft(10, '0').Substring(0, 10) + "|";
            result += b.ToString("0.00").PadLeft(10) + "|" + c.ToString("0.000").PadRight(10) + "|";
            Console.WriteLine(result);
        }
    }
}
