using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortStudents
{
    class SortStudents
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string[]> lines = new List<string[]>();
            while (input != "END")
            {
                lines.Add(input.Split());
                input = Console.ReadLine();
            }
            List<string[]> result = lines.OrderBy(r => r[1])
                .ThenByDescending(r => r[0]).ToList();
            result.ForEach(r => Console.WriteLine(r[0] + " " + r[1]));
        }
    }
}
