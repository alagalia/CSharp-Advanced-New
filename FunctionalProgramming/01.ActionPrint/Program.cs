using System;
namespace _01.ActionPrint
{
    public class Program
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string> printName = s => Console.WriteLine("Sir " + s);

            Array.ForEach(names, printName);
        }
    }
}
