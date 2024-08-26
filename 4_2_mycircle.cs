using System;
namespace Nbin_Lab_4
{
    internal class mycircle
    {
        public static void Main(string[] args)
        {
            circle c1 = new circle(23);
            float area = c1.findArea();
            float circuference = c1.findArea();
            Console.WriteLine("area is: " + area);
            Console.WriteLine("circuference is:" + circuference);
            Console.ReadKey();
        }
    }
}
