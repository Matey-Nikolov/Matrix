using System;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int[,] testMatrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int a = 0; a < col; a++)
                {
                    testMatrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row1 = 0; row1 < testMatrix.GetLength(0); row1++)
            {
                for (int col1 = 0; col1 < testMatrix.GetLength(0); col1++)
                {
                    Console.Write(testMatrix[row1, col1]);
                }
                Console.WriteLine();
            }
        }
    }
}
