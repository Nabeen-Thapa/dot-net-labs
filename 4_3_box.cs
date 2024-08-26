using System;

namespace Nbin_Lab_4
{
    internal class _4_3_box
    {
        public class Box
        {
            private int width, height, depth;
            public Box(int w, int h, int d)
            {
                width = w;
                height = h;
                depth = d;
            }

            public int findVolume()
            {
                return width * height * depth;
            }

            public int findSurfaceArea()
            {
                return 2 * ((width * height) + (height * depth) + (depth + width));
            }
        }
        public class MyBox
        {
            public static void Main(string[] args)
            {
                Box b1 = new Box(5, 10, 15);
                int surface = b1.findSurfaceArea();
                int volume = b1.findVolume();

                Box b2 = new Box(10, 5, 7);
                int surface2 = b2.findSurfaceArea();
                int volume2 = b2.findVolume();
                Console.WriteLine("for first box :");
                Console.WriteLine("The surface area is :" + surface);
                Console.WriteLine("The volume is :" + volume);
                Console.WriteLine();
                Console.WriteLine("for second box :");
                Console.WriteLine("The surface area is :" + surface2);
                Console.WriteLine("The volume is :" + volume2);

                Console.ReadKey();
            }
        }
    }
}
