using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExcellentStudents
{
    class ExcellentStudents
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

            List<string> result = lines.Where(r => r.Contains("6")).ToList();

            result.ForEach(r => Console.WriteLine(r.Split()[0] + " " + r.Split()[1]));
        }
    }
}
