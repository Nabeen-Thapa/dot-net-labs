using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class cube_natural
    {
        public static void Main(string[] args)
        {
            Console.Write("enter no. fo terms to find cube:");
            int cube = int.Parse(Console.ReadLine());
            int num = 1;
        Label:   
            int result = num * num * num;
            Console.WriteLine("cube of " + num + " is " + result);
            if (num < cube)
            {
                num++;
                goto Label;
            }
            Console.ReadKey();
            
        }
    }
}
