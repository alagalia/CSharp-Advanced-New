using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterStudentsbyPhone
{
    public static class FilterStudentsbyPhone
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string[]> lines = new List<string[]>();
            while (input != "END")
            {
                lines.Add(input.Split());
                input = Console.ReadLine();
            }

            List<string[]> result = lines.Where(r => r[2].StartsWith("02") || r[2].StartsWith("+3592")).ToList();

            result.ForEach(r => Console.WriteLine(r[0] + " " + r[1]));
        }
    }
}
