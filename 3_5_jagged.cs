using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_5_jagged
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[1];
            arr[2] = new int[2];

            arr[0][0] = 3;
            arr[0][1] = 1;
            arr[0][2] = 5;
            arr[1][0] = 7;
            arr[2][0] =20;
            arr[2][1] = 10;


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
