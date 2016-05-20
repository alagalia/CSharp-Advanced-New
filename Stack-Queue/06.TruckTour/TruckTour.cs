namespace _06.TruckTour
{
    using System;
    using System.Collections.Generic;

    class TruckTour
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                GasPump currentGasPump = new GasPump(int.Parse(line[0]), int.Parse(line[1]), i);
                pumps.Enqueue(currentGasPump);
            }

            bool isEndReached = false;

            while (true)
            {
                GasPump current = pumps.Dequeue();
                pumps.Enqueue(current);
                GasPump startGasPump = current;
                int fuel = current.amountOfGas;

                while (fuel >= current.distanceToNext)
                {
                    fuel -= current.distanceToNext;
                    current = pumps.Dequeue();
                    pumps.Enqueue(current);
                    if (current == startGasPump)
                    {
                        isEndReached = true;
                        break;
                    }
                    fuel += current.amountOfGas;
                }

                if (isEndReached)
                {
                    Console.WriteLine(startGasPump.index);
                    break;
                }
            }

        }
    }

    public class GasPump
    {
        public int amountOfGas;
        public int distanceToNext;
        public int index;

        public GasPump(int amountOfGas, int distanceToNext, int index)
        {
            this.amountOfGas = amountOfGas;
            this.distanceToNext = distanceToNext;
            this.index = index;
        }
    }
}
