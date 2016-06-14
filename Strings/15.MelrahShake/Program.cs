using System;
namespace _15.MelrahShake
{
    using System.Text;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            while (true)
            {
                int firstIndex = input.IndexOf(pattern);
                int lastIndex = input.LastIndexOf(pattern);
                if (firstIndex != lastIndex &&
                    firstIndex > -1 &&
                    lastIndex > -1 &&
                    pattern.Length > 0)
                {
                    StringBuilder sb = new StringBuilder(input);
                    sb.Remove(lastIndex, pattern.Length);
                    sb.Remove(firstIndex, pattern.Length);
                    input = sb.ToString();

                    Console.WriteLine("Shaked it.");

                    sb = new StringBuilder(pattern);
                    if (sb.Length > 0)
                    {
                        sb.Remove(pattern.Length / 2, 1);
                        pattern = sb.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }

            Console.WriteLine(input);

        }
    }
}
