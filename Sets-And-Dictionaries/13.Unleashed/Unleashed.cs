namespace _13.Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Unleashed
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> info = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] args = line.Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);
                if (args.Length > 1 && args[1].Split().Length > 1)
                {
                    string singer = args[0];
                    Stack<string> venuePriceCount = new Stack<string>(args[1].Split());

                    long ticketCount;
                    bool isTicketCountValid = long.TryParse(venuePriceCount.Pop(), out ticketCount);

                    long ticketPrice;
                    bool isTicketPriceValid = long.TryParse(venuePriceCount.Pop(), out ticketPrice);

                    if (isTicketCountValid && isTicketPriceValid)
                    {
                        string[] venueAsArray = venuePriceCount.ToArray();
                        string venue = string.Join(" ", venueAsArray.Reverse());

                        // input is checked as valid
                        if (!info.ContainsKey(venue))
                        {
                            info.Add(venue, new Dictionary<string, long>());
                        }

                        if (!info[venue].ContainsKey(singer))
                        {
                            info[venue].Add(singer, 0);
                        }

                        info[venue][singer] += ticketCount * ticketPrice;
                    }
                }
            }

            PrintResult(info);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> info)
        {
            foreach (var kvOuter in info)
            {
                Console.WriteLine(kvOuter.Key);
                var sortedByTotal = kvOuter.Value.OrderByDescending(x => x.Value);

                foreach (var kvInner in sortedByTotal)
                {
                    Console.WriteLine("#  " + kvInner.Key + " -> " + kvInner.Value);
                }
            }
        }
    }
}
