﻿namespace _05.ConvertFromBase_NtoBase_10
{
    using System;
    using System.Numerics;

    public class FromBase
    {
        public static void Main()
        {
            string[] line = Console.ReadLine().Trim().Split();
            int baseN = int.Parse(line[0]);
            char[] number = line[1].ToCharArray();
            BigInteger result = new BigInteger(0); 

            for (int i = number.Length - 1, n = 0; i >= 0; i--, n++)
            {
                int num = (int)char.GetNumericValue(number[n]);
                BigInteger forSum = num * new BigInteger(Math.Pow(baseN, i));
                result += forSum;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
