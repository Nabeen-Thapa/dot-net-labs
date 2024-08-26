using System;

namespace Nbin_Lab_4
{
    public struct Company
    {
        string name;
        string address;
        double phone;
        double salary;
        public void setProperty(string name, string address, double phone, double salary)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Company name " + name);
            Console.WriteLine("Company address " + address);
            Console.WriteLine("Company phone " + phone);
            Console.WriteLine("Company salary " + salary);
        }
    };

    internal class Structure
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the address: ");
            string address = Console.ReadLine();
            Console.Write("Enter the phone: ");
            double phone = int.Parse(Console.ReadLine());
            Console.Write("Enter the salary: ");
            double salary = double.Parse(Console.ReadLine());
            company.setProperty(name, address, phone, salary);
            company.Display();
            Console.ReadKey();


        }
    }
}
