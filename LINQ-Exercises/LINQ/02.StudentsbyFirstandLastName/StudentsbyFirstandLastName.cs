using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsbyFirstandLastName
{
    class StudentsbyFirstandLastName
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string[]> lines = new List<string[]>();
            while (input != "END")
            {
                lines.Add(input.Split());
                input = Console.ReadLine();
            }

            List<string[]> result = lines.Where(l => l[0].CompareTo(l[1]) == -1).ToList();
            result.ForEach(r => Console.WriteLine(r[0] + " " + r[1]));
        }
    }
}
