using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JediDreams
{
    using System.Text.RegularExpressions;

    class JediDreams
    {
        static void Main(string[] args)
        {
            SortedSet<string> a= new SortedSet<string>();
            a[1];
            while (true)
            {
                string a = Console.ReadLine();
                List<string> aaa = new List<string>();
                aaa.Add(a.Split()[0]);
                aaa.Add(a.Split()[1]);
                aaa.Add(a.Split()[2]);


                var sorted = aaa.OrderBy(str => str).ToList();
                Console.WriteLine(string.Join(", ", aaa));
                Console.WriteLine(string.Join(", ", sorted));
            }
        }
    }
}
