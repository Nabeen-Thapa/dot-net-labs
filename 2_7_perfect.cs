using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Nabin_lab2
{
    internal class _2_7_perfect
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
                if (sum == temp)
                {
                    Console.WriteLine(temp + "  is perfect");
                }
                else
                {
                    Console.WriteLine(temp +"  is not perfect");
                }
                Console.ReadKey();
            
        }
    }
}
