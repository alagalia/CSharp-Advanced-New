using System;
using System.Linq;
using System.Text;

namespace _07.SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine().ToList();
            var secondNum = Console.ReadLine().ToList();

            StringBuilder sb = new StringBuilder();

            int loop = Math.Max(firstNum.Count, secondNum.Count);
            int remainder = 0;
            for (int i = 0; i <= loop; i++)
            {
                int firstCurrentChar;
                int secondCurrentChar;

                if (firstNum.Count == 0)
                {
                    firstCurrentChar = 0;
                }
                else
                {
                    firstCurrentChar = int.Parse(firstNum.Last().ToString());
                    firstNum.RemoveAt(firstNum.Count - 1);
                }

                if (secondNum.Count == 0)
                {
                    secondCurrentChar = 0;
                }
                else
                {
                    secondCurrentChar = int.Parse(secondNum.Last().ToString());
                    secondNum.RemoveAt(secondNum.Count - 1);
                }

                int result = firstCurrentChar + secondCurrentChar + remainder;
                sb.Append(result % 10);
                remainder = result / 10;
            }
            

            Console.WriteLine(Reverse(sb.ToString()).TrimStart('0'));
        }

        public static string Reverse(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }
    }
}
