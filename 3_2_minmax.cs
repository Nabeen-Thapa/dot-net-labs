using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_2_minmax
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the  size of array:");
            int size = int.Parse(Console.ReadLine());
            int[] odd = new int[size];
            int i;
            Console.WriteLine("enter the array welements: ");
            for ( i = 0; i < size; i++)
                odd[i] = int.Parse(Console.ReadLine());
            int min = odd[0];
            int max = odd[0];
            for (i = 0; i < odd.Length; i++)
            {
                if (min > odd[i])
                {
                    min = odd[i];
                }
                if (max < odd[i])
                {
                    max = odd[i];
                }
            }
                Console.WriteLine("maximun is:" + max);
                Console.WriteLine("minimum: " + min);
            
            Console.ReadKey();
        }
    }
}
