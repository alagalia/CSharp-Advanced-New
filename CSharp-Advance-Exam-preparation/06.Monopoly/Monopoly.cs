using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Monopoly
{
    class Monopoly
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine().Split()[0]);
            int money = 50;
            int numberOfHotels = 0;
            int turns = 0;

            for (int row = 0; row < rows; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    int index = row % 2 == 0 ? col : currentRow.Length - col - 1;

                    char command = currentRow[index];

                    switch (command)
                    {
                        case 'H':
                            numberOfHotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {numberOfHotels}.");
                            money = 0;
                            break;
                        case 'J':
                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 2;
                            money += 2 * numberOfHotels * 10;
                            break;
                        case 'S':
                            int realCol = row % 2 == 0 ? col : currentRow.Length - col - 1;
                            int spent = Math.Min((row + 1) * (realCol + 1), money);
                            money -= spent;
                            Console.WriteLine($"Spent {spent} money at the shop.");
                            break;
                    }
                    money += numberOfHotels * 10;
                    turns++;
                }
            }
            Console.WriteLine("Turns " + turns);
            Console.WriteLine("Money " + money);
        }
    }
}
