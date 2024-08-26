using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nabin_lab_5
{
   
        public class person
        {
            string name;

            public void setname(string name)
            {
                this.name = name;
            }
            public string getname()
            {
                return name;

            }
        }
        public class employee : person
        {
            int eid;
            public void seteid(int eid)
            {
                this.eid = eid;
            }
            public int geteid()
            {
                return eid;
            }

        }
    internal class _5_2_single_inherit
    {
        public static void Main(string[] args)
        {
            employee emp = new employee();
            emp.setname("Ram");
            emp.seteid(1);
            Console.WriteLine("single inherit");
            Console.WriteLine("employee name is: " + emp.getname());
            Console.WriteLine("employee id is  :" + emp.geteid());
            Console.ReadKey();
        }
    }
}
