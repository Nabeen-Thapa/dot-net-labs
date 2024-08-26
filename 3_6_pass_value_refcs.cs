using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_Lab_3
{
    internal class _3_5_pass_value_refcs
    {
       public static void reference(ref int p)
       {
            p = p+1;
          
            Console.WriteLine("p= " +p);
       }
        public static void Main(string[] args) {
            int x = 5;
            Console.WriteLine("before call: x= " + x);
            reference(ref x);
            Console.WriteLine("after call: x= " + x);
            Console.ReadKey();
        }
    }
}
