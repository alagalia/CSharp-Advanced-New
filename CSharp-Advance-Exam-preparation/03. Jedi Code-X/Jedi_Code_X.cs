using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Jedi_Code_X
{
    using System.Text.RegularExpressions;

    class Jedi_Code_X
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                sb.Append(line);
            }

            string nameInputPattern = Console.ReadLine();
            string msgInputPattern = Console.ReadLine();


            Regex nameRegex = new Regex(nameInputPattern + @"([a-zA-Z]{" + nameInputPattern.Length + @"})(?![a-zA-Z])");

            Regex msgRegex = new Regex(msgInputPattern + @"([a-zA-Z0-9]{" + msgInputPattern.Length + @"})(?![a-zA-Z0-9])");

            MatchCollection nameCollection = nameRegex.Matches(sb.ToString());
            MatchCollection msgMatches = msgRegex.Matches(sb.ToString());

            List<string> nameList = new List<string>();
            foreach (Match jedy in nameCollection)
            {
                nameList.Add(jedy.Groups[1].Value);
            }

            List<string> msgList = new List<string>();
            foreach (Match msg in msgMatches)
            {
                msgList.Add(msg.Groups[1].Value);
            }

            int[] possition = Console.ReadLine().Split().Select(int.Parse).ToList().Where(p => p <= msgList.Count).ToArray();
            int[] validposition = possition.Take(Math.Min(nameList.Count, possition.Length)).ToArray();

            for (int i = 0; i < validposition.Length; i++)
            {
                Console.WriteLine(nameList[i] + " - " + msgList[validposition[i] - 1]);
            }

        }
    }
}
