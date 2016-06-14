using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().TrimStart('0').ToList();
            string secondNum = Console.ReadLine().TrimStart('0');

            if (firstNum.Count == 0 || secondNum.Length == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                int remainder = 0;

                while (firstNum.Count > 0)
                {
                    int firstCurrentChar = int.Parse(firstNum.Last().ToString());
                    firstNum.RemoveAt(firstNum.Count - 1);

                    int result = (firstCurrentChar * int.Parse(secondNum)) + remainder;
                    int forAppend = result % 10;
                    sb.Append(forAppend);
                    remainder = result / 10;
                }

                sb.Append(remainder);

                Console.WriteLine(Reverse(sb.ToString()).TrimStart('0'));
            }
        }

        public static string Reverse(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }
    }
}
