using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbin_Lab_4
{
   public class Distance
    {
        private int feet, inch;
        public Distance(int f, int i)
        {
            feet = f;
            inch = i;
        }

        public void addDistance(int f, int i)
        {
            feet += f;
            inch += i;
            if (inch >= 12)
            {
                feet += inch / 12;
                inch %= 12;

            }
        }

        public void substractDistance(int f, int i)
        {
            feet += f;
            inch += i;
            if (inch < 0)
            {
                feet -= (Math.Abs(inch) / 12) + 1;
                inch = 12 - (Math.Abs(inch) % 12);
            }
        }

        public void displayDistance()
        {
            Console.WriteLine("The distance is " + feet + " feet and " + inch + " inch");
        }

    }
    internal class MyDistance
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(5, 7);
            Console.WriteLine("Initial Display:");
            d1.displayDistance();
            d1.addDistance(2, 20);
            Console.WriteLine();
            Console.WriteLine("Adding Distance");
            d1.displayDistance();
            d1.substractDistance(10, 12);
            Console.WriteLine();
            Console.WriteLine("Substracting Distance");
            d1.displayDistance();
            Console.ReadKey();
        }
    }
}
