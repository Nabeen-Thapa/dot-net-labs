using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nabin_lab_5._5_2_single_inherit;

namespace Nabin_lab_5
{
    internal class _5_2_multi
    {
        
        public class student: employee
        {
            int roll;
            public void setroll(int roll)
            {
                this.roll = roll;
            }
            public int getroll()
            {
                return this.roll;
            }
        }
        public static void Main(string[] args) {
            student s1 = new student();
            s1.setname("shyam");
            s1.setroll(10);
            Console.WriteLine("multilevel inherit");
            Console.WriteLine("studnet name is: " + s1.getname());
            Console.WriteLine("student roll is: " + s1.getroll());
            Console.ReadKey();
        }
    }
}
