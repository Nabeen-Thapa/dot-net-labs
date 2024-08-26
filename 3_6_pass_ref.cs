using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_6_pass_ref
    {
        public static void reference(ref int p)
        {
            p = p + 1;
            Console.WriteLine("p= " + p);
        }
        public static void value(int v)
        {
            v = v + 1;
            Console.WriteLine("v= " + v);
        }
        public static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("pass by reference " );
            Console.WriteLine("before call: x= " + x);
            reference(ref x);
            Console.WriteLine("after call: x= " + x);
            Console.WriteLine("");
            Console.WriteLine("pass by value ");
            Console.WriteLine("before call: x= " + y);
            value(y);
            Console.WriteLine("after call: x= " + y);


            Console.ReadKey();
        }
    }
}
