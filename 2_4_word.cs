﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab2
{
    internal class _2_4_word
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number for word:");
            int word = int.Parse(Console.ReadLine());
            switch (word)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                   case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                    default: 
                    Console.WriteLine("invalid input");
                    break ;
            }
            Console.ReadKey();
        }
    }
}
