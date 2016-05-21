using System;
using System.Collections.Generic;
namespace _10.SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> textsStack = new Stack<string>();
            textsStack.Push(text);

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                switch (commandArgs[0])
                {
                    case "1":
                        text += commandArgs[1];
                        textsStack.Push(text);
                        break;

                    case "2":
                        int count = int.Parse(commandArgs[1]);
                        text = text.Remove(text.Length - count, count);
                        textsStack.Push(text);
                        break;

                    case "3":
                        int index = int.Parse(commandArgs[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        textsStack.Pop();
                        text = textsStack.Peek();
                        break;
                }
            }
        }
    }
}
