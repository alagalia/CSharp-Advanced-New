using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.JediMeditation
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> m = new HashSet<string>();
            HashSet<string> k = new HashSet<string>();
            HashSet<string> p = new HashSet<string>();
            HashSet<string> ourHeroes = new HashSet<string>();
            string yoda = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] jedies = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                jedies.ToList().ForEach(
                    j =>
                        {
                            if (j[0] == 'm')
                            {
                                m.Add(j);
                            }
                            else if (j[0] == 'k')
                            {
                                k.Add(j);
                            }
                            else if (j[0] == 'p')
                            {
                                p.Add(j);
                            }
                            else if (j[0] == 'y')
                            {
                                yoda = j;
                            }
                            else
                            {
                                ourHeroes.Add(j);
                            }
                        });
            }

            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(yoda))
            {
                result.AddRange(ourHeroes);
                result.AddRange(m);
                result.AddRange(k);
                result.AddRange(p);
            }
            else
            {
                result.AddRange(m);
                result.AddRange(k);
                result.AddRange(ourHeroes);
                result.AddRange(p);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
