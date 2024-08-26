using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_first
{
    internal class digit_add
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("enter the number to add the digits: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int div;
            while (num > 0) { 
                div = num % 10;
                sum += div;
                num = num/10;

            }
            Console.WriteLine("the sum is : " + sum);
            Console.ReadKey();

        }
    }
}
