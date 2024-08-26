using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class _2_positive_sum
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
               
                Console.Write("enter the number: ");
                   int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("negative number");
                    break;
                } 
               else
                {
                    sum += num;
                
                Console.WriteLine("sum is: " + sum);
                }

            }
           
            Console.ReadKey();  
        }
    }
}
