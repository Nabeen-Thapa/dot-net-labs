using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_8_params
    {
        public static int add(int x, params int[] num)
        {
            Console.WriteLine("x = " + x);
            int sum = x;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;

        }
        public static int mul(params int[] num)
        {

            int mul = 1;
            foreach (int i in num)
            {
                mul *= i;
            }
            return mul;

        }
        public static void Main(string[] args)
        {
            int a = add(1, 2, 3, 5, 6, 4, 7);
            Console.WriteLine("With x and params : " + a);
            int b = mul(1, 2, 3, 5);
            Console.WriteLine("With params only: " + b);

            Console.ReadKey();
        }
    }
}
