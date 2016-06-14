namespace _12.InfernoIII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InfernoIII
    {
        public class MyNum
        {
            public int value { get; set; }

            public bool isLegal { get; set; }

            public MyNum(int value, bool islegal)
            {
                this.value = value;
                this.isLegal = islegal;
            }
        }

        public static void Main()
        {
            Func<int, int, int, bool> isLegalLeftOrRight = (mainNum, additionalNum, parameter) =>
            {
                if (mainNum + additionalNum == parameter)
                {
                    return true;
                }

                return false;
            };

            Func<int, int, int, int, bool> isLegalLeftAndRight = (mainNum, leftNum, rightNum, parameter) =>
            {
                if (mainNum + leftNum + rightNum == parameter)
                {
                    return true;
                }

                return false;
            };

            List<int> tempNum = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<MyNum> nums = tempNum.Select(num => new MyNum(num, false)).ToList();

            Stack<string> allCommands = new Stack<string>();
            string line = Console.ReadLine();

            while (line != "Forge")
            {
                string[] comandInfo = line.Split(';');
                if (comandInfo[0] == "Exclude")
                {
                    allCommands.Push(comandInfo[1] + ';' + comandInfo[2]);
                }
                else if (comandInfo[0] == "Reverse")
                {
                    allCommands.Pop();
                }

                line = Console.ReadLine();
            }

            string[] commands = allCommands.ToArray();
            Array.Reverse(commands);

            foreach (string command in commands)
            {
                string[] commandProperties = command.Split(';');
                string filterType = commandProperties[0];
                int parameter = int.Parse(commandProperties[1]);

                for (int i = 0; i < nums.Count; i++)
                {
                    int main = nums[i].value;
                    int left = i == 0 ? 0 : nums[i - 1].value;
                    int right = i == nums.Count - 1 ? 0 : nums[i + 1].value;

                    if (filterType == "Sum Left")
                    {
                        nums[i].isLegal = nums[i].isLegal || isLegalLeftOrRight(main, left, parameter);
                    }
                    else if (filterType == "Sum Right")
                    {
                        nums[i].isLegal = nums[i].isLegal || isLegalLeftOrRight(main, right, parameter);
                    }
                    else if (filterType == "Sum Left Right")
                    {
                        //mainNum, leftNum, rightNum, parameter
                        nums[i].isLegal = nums[i].isLegal || isLegalLeftAndRight(main, left, right, parameter);
                    }
                }
            }

           List<int> result = nums.Where(num => num.isLegal == false).Select(num => num.value).ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
