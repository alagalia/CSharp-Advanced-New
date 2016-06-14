using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ExtractHyperlinks
{
    using System.Text.RegularExpressions;

    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            while (line!="END")
            {
                sb.Append(line);
                sb.Append("\n");
                line = Console.ReadLine();
            }
            string pattern1 = @"<a([^>]*?)\s?href\s*=\s*(((""|')(.+?)\4)|([^>\s?]*))";

            string input = sb.ToString();

            Regex reg = new Regex(pattern1);
            MatchCollection matches = reg.Matches(input);

            foreach (Match m in matches)
            {
                if (m.Groups[5].Success)
                {
                    Console.WriteLine(m.Groups[5].Value);
                }
                else if (m.Groups[6].Success)
                {
                    Console.WriteLine(m.Groups[6].Value);
                }
            }
        }
    }
}
