namespace _09.StudentsEnrolledIn2014or2015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsEnrolledIn2014or2015
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string[]> lines = new List<string[]>();
            while (input != "END")
            {
                string[] studentInfo = input.Split();
                lines.Add(
                    new[]
                        {
                            studentInfo[0], studentInfo[1], studentInfo[2], studentInfo[3], studentInfo[4]
                        });
                input = Console.ReadLine();
            }

            var result = lines
                .Where(student => student[0].EndsWith("14") || student[0].EndsWith("15")).ToList();

            result.ForEach(student => student.ToList().RemoveAt(0));

            result.ForEach(s => Console.WriteLine(string.Join(" ", s.Skip(1))));
        }
    }
}
