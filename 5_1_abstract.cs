using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab_5
{
    
        public abstract class shape
        {
            public double dim1;
            public double dim2;
            public shape(double dim1, double dim2) { 
                this.dim1 = dim1;
                this.dim2 = dim2;
            }
            public abstract double area();

        }
        public class triangle: shape
        {
            public triangle(double b, double h) : base(b, h)
            {

            }
            public override double area()
            {
                return (0.5 * dim1 * dim2);
            }
        }
        internal class Abstract
        {
            static void Main(string[] args)
            {
                triangle t1 = new triangle(2, 10);
                Console.WriteLine("area of trianle is: "+t1.area());
                Console.ReadKey();
            }
        }
    }

