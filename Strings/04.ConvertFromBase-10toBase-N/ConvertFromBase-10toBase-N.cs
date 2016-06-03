
namespace _04.ConvertFromBase_10toBase_N
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            string[] arguments = Console.ReadLine().Split();

            BigInteger toBase = BigInteger.Parse(arguments[0]);
            BigInteger number = BigInteger.Parse(arguments[1]);

            string parsedNum = string.Empty;

            do
            {
                parsedNum += number % toBase;
                number /= toBase;
            }
            while (number > 0);

            char[] toBeReversed = parsedNum.ToCharArray();
            Array.Reverse(toBeReversed);
            string result = string.Join(string.Empty, toBeReversed);

            Console.WriteLine(result);
        }
    }
}
