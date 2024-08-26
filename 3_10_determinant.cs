using System;
namespace Nabin_Lab_3
{
    internal class _3_10_determinant
    {
        public static void Main(String[] args)
        {
            int[,] x = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int determinant = 0;
            Console.WriteLine("array elements of x=");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            determinant = x[0, 0] * (x[1, 1] * x[2, 2] - x[1, 2] * x[2, 1]);
            determinant -= x[0, 1] * (x[1, 0] * x[2, 2] - x[1, 2] * x[2, 0]);
            determinant -= x[0, 2] * (x[1, 0] * x[2, 1] - x[1, 1] * x[2, 0]);
            Console.WriteLine("Determinatnt of x=" + determinant);
            Console.ReadKey();
        }
    }
}
