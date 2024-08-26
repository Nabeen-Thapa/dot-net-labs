using System;
namespace Nabin_lab2
{
    internal class _2_8_fibo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number of terms:");
            int num =int.Parse(Console.ReadLine()); 
            int i, c, a = 0, b = 1;
            Console.Write(a + " " + b);
            for (i = 0; i < num - 1; i++)
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
            Console.ReadKey();

        }
    }
}
