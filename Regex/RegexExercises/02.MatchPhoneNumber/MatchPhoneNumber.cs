using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string pattern = @"\+359([\s|-])2\1\d{3}\1\d{4}\b";

            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            while (input != "end")
            {
                bool ismatch = regex.IsMatch(input);
                if (ismatch)
                {
                    Console.WriteLine(input.Trim());
                }

                input = Console.ReadLine();
            }
        }
    }
}
