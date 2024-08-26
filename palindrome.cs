using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_first
{
    internal class palindrome
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("enter the munber to check palindrome: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int mod;
            int sum = 0;
            while (num > 0)
            {
                mod = num % 10;
                sum = sum *10 + mod ;
                num /= 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
                
            }
            Console.ReadKey();
        }
    }
}
