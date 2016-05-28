namespace SetsAndDictionaries
{
    using System;
    using System.Collections.Generic;

    public class BasicSetOperations
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string userName = Console.ReadLine();
                userNames.Add(userName);
            }

            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
