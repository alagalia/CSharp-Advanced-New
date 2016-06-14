using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main()
        {
            Func<int, int, bool> ifLegal = (wordLength, num) => wordLength <= num; 
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            List<string> result = names.Where(name => ifLegal(name.Length, n)).ToList();
            result.ForEach(r => Console.WriteLine(r));
        }
    }
}
