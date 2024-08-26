using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class lab2
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("enter the number:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }else if (num < 0) 
            {
                Console.WriteLine("number is positive");
            }
            else 
            
                {
                    Console.WriteLine("number is zero");
                }
                Console.ReadKey();
        }
    }
}
