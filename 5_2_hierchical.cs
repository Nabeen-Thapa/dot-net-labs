using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nabin_lab_5
{
     public class students:person
    {
        string sem;
        public void setsem(string sem)
        {
            this.sem = sem;
        }
        public string getsem()
        {
            return sem;
        }
    }
    public class _5_2_hierchical
    {
       
        public static void Main(string[] args) {
            students std = new students();
            std.setname("Hari");
            std.setsem("fifth");
            Console.WriteLine("studnet name is:" +std.getname());
            Console.WriteLine("semester is :" +std.getsem());
            Console.ReadKey();
        }
    }
}
