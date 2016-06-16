using System;
using System.Linq;

namespace _02.Jedi_Galaxy
{
    class Jedi_Galaxy
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowN = dimensions[0];
            int colM = dimensions[1];
            string ivoSting = Console.ReadLine();
            long ivoNum = 0;
            int[,] matrix = new int[rowN, colM];
            FilMatrix(matrix, rowN, colM);

            while (ivoSting != "Let the Force be with you")
            {
                string evilString = Console.ReadLine();
                int[] ivo = ivoSting.Split().Select(int.Parse).ToArray();
                int[] evil = evilString.Split().Select(int.Parse).ToArray();

                int ivoRow = ivo[0];
                int ivoCol = ivo[1];

                int evilRow = evil[0];
                int evilCol = evil[1];

                while (evilRow >= 0 && evilCol >= 0)
                {
                    if (IsInMatrix(matrix, evilRow, evilCol))
                    {
                        matrix[evilRow, evilCol] = 0;
                    }

                    evilCol--;
                    evilRow--;
                }


                while (ivoRow >= 0 && ivoCol < colM)
                {
                    if (IsInMatrix(matrix, ivoRow, ivoCol))
                    {
                        ivoNum += matrix[ivoRow, ivoCol];
                    }

                    ivoRow--;
                    ivoCol++;
                }

                ivoSting = Console.ReadLine();
            }

            Console.WriteLine(ivoNum);
        }

        private static bool IsInMatrix(int[,] matrix, int givenRow, int givenCol)
        {
            bool result = givenRow >= 0 
                && givenRow < matrix.GetLength(0) 
                && givenCol >= 0 
                && givenCol < matrix.GetLength(1);
            return result;
        }

        private static void FilMatrix(int[,] matrix, int rowN, int colM)
        {
            int counter = 0;
            for (int row = 0; row < rowN; row++)
            {
                for (int col = 0; col < colM; col++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }
    }
}