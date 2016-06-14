using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentsbyAge
{
    class StudentsbyAge
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
            List<string[]> result = lines.Where(l => int.Parse(l[2]) >= 18 && int.Parse(l[2]) <= 24).ToList();
            result.ForEach(r => Console.WriteLine(r[0] + " " + r[1] + " " + r[2]));
        }
    }
}
