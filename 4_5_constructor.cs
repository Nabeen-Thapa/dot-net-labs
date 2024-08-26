using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Nbin_Lab_4
{
    internal class staticconstructor
    {
        static string name;
        static int roll;

        static staticconstructor()
        {
            name = "Nabin Tapa";
            roll = 100;
        }
        public static void printdata()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("roll no. is: " +roll);
        }

    }
    public class mainconstructorclass
    {
        public static void Main(string[] args)
        {
            staticconstructor.printdata();
            Console.ReadKey();
        }
    }

}
