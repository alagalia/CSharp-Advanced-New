namespace _07BalancedParentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BalancedParentheses
    {
        static void Main()
        {
            char[] parentheses = Console.ReadLine().ToCharArray();
            string result;
            char[] openParentheses = { '[', '{', '(' };
            char[] closeParentheses = { ']', '}', ')' };
            bool allSame = parentheses.All(item => item == 32);

            if (parentheses.Length % 2 != 0 || parentheses.Length == 0 || allSame)
            {
                result = "NO";
<<<<<<< HEAD
            } 
=======
            }
>>>>>>> remotes/C#NEW/master
            else
            {
                Queue<char> queue = new Queue<char>();
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < parentheses.Length; i++)
                {
                    if (openParentheses.Contains(parentheses[i]))
                    {
                        queue.Enqueue(parentheses[i]);
                    }
                    else if (closeParentheses.Contains(parentheses[i]))
                    {
                        stack.Push(parentheses[i]);
                    }
<<<<<<< HEAD
                    else if (parentheses[i] == ' ' && (i % 2 == 0))
                    {
                        queue.Enqueue(' ');
                    }
                    else if (parentheses[i] == ' ' && (i % 2 != 0))
=======
                    else if (parentheses[1] == ' ' && (i % 2 == 0))
                    {
                        queue.Enqueue(' ');
                    }
                    else if (parentheses[1] == ' ' && (i % 2 != 0))
>>>>>>> remotes/C#NEW/master
                    {
                        stack.Push(' ');
                    }
                }

                bool isEqual = true;
                
                for (int i = 0; i < queue.Count; i++)
                    {
                        char left = queue.Dequeue();
                        char right = stack.Pop();
                        bool leftEqualToRignt = ((left == '[' && right == ']') || (left == '{' && right == '}') || (left == '(' && right == ')') || left == right);

                        if (!leftEqualToRignt)
                        {
                            isEqual = false;
                            break;
                        }
                    }
                
                result = isEqual ? "YES" : "NO";
            }

            Console.WriteLine(result);
        }
    }
}
