using System;
namespace Nabin_lab2
{
    internal class _2_6_armstrong
    {
        public static void Main(string[]args)
        {  
            Console.WriteLine("enter the number :");
            int num = int.Parse(Console.ReadLine());
            int number = num;
            int digits = Math.Abs(num).ToString().Length;
            double sum = 0;
            while (num > 0)
            {
                
                sum +=Math.Pow((num % 10), digits);
                num = num / 10;
            }
            if (sum == number)
            {
                Console.WriteLine("number is armstrong");
            }
            else {
                Console.WriteLine("number is not armstrong");
            }
            Console.ReadKey();

        }
    }
}
