using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class lab_2_3_largest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the three number:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is largest");
                }
                else
                {
                    Console.WriteLine(num3 + " is largest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is largest");
                }
                else
                {
                    Console.WriteLine(num3 + " is largest");
                }
               
            }
            Console.ReadKey();
        }
    }
}
