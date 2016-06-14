using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsbyGroup
{
    class StudentsbyGroup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> lines = new List<string>();
            while (input != "END")
            {
                lines.Add(input);
                input = Console.ReadLine();
            }

            var groupTwo = lines
                .Where(l => l.Contains("2")).OrderBy(a => a.Split()[0]).ToList();
            groupTwo.ForEach(s => Console.WriteLine(s.Split()[0] + " " + s.Split()[1]));
        }
    }
}
