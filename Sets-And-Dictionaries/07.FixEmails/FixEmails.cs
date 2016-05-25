
namespace _07.FixEmails
{
    using System;
    using System.Collections.Generic;

    class FixEmails
    {
        static void Main()
        {
            Dictionary<string, string> mailInfo = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }

                string name = line;
                string mail = Console.ReadLine();
                bool isMailValid = MailValid(mail);
                if (isMailValid)
                {
                    mailInfo.Add(name, mail);
                }

            }

            foreach (var kv in mailInfo)
            {
                Console.WriteLine(kv.Key + " -> " + kv.Value);
            }
        }

        private static bool MailValid(string mail)
        {
            string extention = mail.Split('.')[1].ToLower();
            if (extention == "us" || extention == "uk")
            {
                return false;
            }

                return true;
        }
    }
}
