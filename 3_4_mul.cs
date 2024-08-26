using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_4_mul
    {
        public static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 1 } };
            int[,] b = new int[3, 3] { { 2, 2, 4 }, { 4, 5, 8 }, { 9, 8, 3 } };
            int[,] mul = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        mul[i, k] = mul[i, k] + a[i, j] * b[j, k];
                    }
                }
            }
            Console.WriteLine("multiplication is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mul[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
