namespace _13.TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TriFunction
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> isLegal = (name, value) =>
                {
                    int nameValue = 0;
                    foreach (char c in name)
                    {
                        nameValue += c;
                    }

                    return nameValue >= value;
                };
            List<string> result = names.Where(name => HelperMethod(name, num, isLegal)).ToList();
            Console.WriteLine(result.FirstOrDefault());
        }

        private static bool HelperMethod(string name, int num, Func<string, int, bool> isLegal)
        {
            return isLegal(name, num);
        }
    }
}
