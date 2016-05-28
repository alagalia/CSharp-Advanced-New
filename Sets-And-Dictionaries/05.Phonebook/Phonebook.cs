
namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (line != "search")
            {
                string[] userAndPhone = line.Split('-');
                string user = userAndPhone[0];
                string phone = userAndPhone[1];
                if (!phoneBook.ContainsKey(user))
                {
                   phoneBook.Add(user, phone);
                }
                else
                {
                    phoneBook[user] = phone;
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "stop")
            {
                if (!phoneBook.ContainsKey(line))
                {
                    Console.WriteLine("Contact {0} does not exist.", line);
                }
                else
                {
                    string phone = phoneBook[line];
                    Console.WriteLine("{0} -> {1}", line, phone);
                }

                line = Console.ReadLine();
            }
        }
    }
}
