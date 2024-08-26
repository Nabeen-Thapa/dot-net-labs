using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class _2_5_prime
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter the number to check prime or not:");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 2; i < num; i++)
            {
                if (num%i == 0)
                {
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine(num + "  is prime");
            }
            else
            {
                Console.WriteLine(num + "  not prime"); 
            }

            Console.ReadKey();
        }
    }
}
