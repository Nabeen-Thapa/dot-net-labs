using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_first
{
    internal class factorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter nay number  to find factorial:");
            int num = int.Parse(Console.ReadLine());
            int sum = 1;
            while (num > 0)
            {
                sum = sum *num ;
                num--;
            }
            Console.WriteLine("the factortial is : " + sum);
            Console.ReadKey();
        }
    }
}
