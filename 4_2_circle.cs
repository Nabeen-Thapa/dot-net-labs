using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbin_Lab_4
{
    internal class circle
    {
        public circle()
        {

        }
        private float radius;
        public circle(float r)
        {
            radius = r;
        }
        public float findArea()
        {
            return 2 * 22/7 * radius * radius;
        }
        public float findcircuference()
        {
            return 2 * 22/7 * radius; 
        }
        public static void Main(string[] args)
        {
            circle c1 = new circle(23);
            float area = c1.findArea();
            float circuference = c1.findcircuference();
            Console.WriteLine("area is: " + area);
            Console.WriteLine("circuference is:" + circuference);
            Console.ReadKey();
        }
    }
}
