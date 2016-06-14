using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FilterStudentsbyEmailDomain
{
    class FilterStudentsbyEmailDomain
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> lines = new List<string>();
            while (input != "END")
            {
                lines.Add(input);
                input = Console.ReadLine();
            }

            var groupTwo = lines
                .Where(l => l.Contains("@gmail.com")).ToList();
            groupTwo.ForEach(s => Console.WriteLine(s.Split()[0] + " " + s.Split()[1]));
        }
    }
}
