using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_7_parameter
    {
        public static int add(int x, int y = 5, int z = 10)
        {
            Console.WriteLine("X= " + x + ",Y= " + y + ",Z= " + z);
            return (x + y + z);

        }
        public static void Main(string[] args)
        {
            int a = add(10, 12, 30);
            Console.WriteLine("Method call with all 3 parameter: " + a);
            int b = add(2, 8);
            Console.WriteLine("Method call with 2 parameter: " + b);
            int c = add(4);
            Console.WriteLine("Method call with 1 parameter: " + c);
            int d = add(x: 5, z: 20, y: 10);
            Console.WriteLine("Method call with named parameter: " + d);

            Console.ReadKey();
        }
    }
}
