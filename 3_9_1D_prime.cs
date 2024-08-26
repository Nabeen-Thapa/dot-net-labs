using System;
namespace Nabin_Lab_3
{
    internal class _3_9_1D_prime
    {
        static void Main()
        {
            int[] array = { 1, 3, 4, 5, 6, 7, 2, 8, 1, 2, 3, 4 };
            Console.Write("array elements:");
            foreach (int a in array)
                Console.Write(a + " ");
            Console.WriteLine();
            Console.Write("prime elements:");
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                
                for (int j = 1; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                        count++;
                }
                if (count == 1)
                    Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

