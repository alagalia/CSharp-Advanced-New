using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.WeakStudents
{
    class WeakStudents
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string[]> lines = new List<string[]>();
            while (input != "END")
            {
                string[] studentInfo = input.Split();
                lines.Add(
                    new[]
                        {
                            studentInfo[0] + " " + studentInfo[1], studentInfo[2], studentInfo[3], studentInfo[4], studentInfo[5]
                        });
                input = Console.ReadLine();
            }

            var result =
                lines.Select(
                    p =>
                    new
                    {
                        key = p[0],
                        valuses = new[] { int.Parse(p[1]), int.Parse(p[2]), int.Parse(p[3]), int.Parse(p[4]) }
                    })
                    .Where(
                        elem =>
                            {
                                List<int> vs = elem.valuses.ToList();
                                List<int> legalList = vs.Where(v => v <= 3).ToList();
                                return legalList.Count > 1;
                            }).ToList();
            result.ForEach(s => Console.WriteLine(s.key));
        }
    }
}
