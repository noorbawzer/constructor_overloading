using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_overloading
{
    class Employee
    {

        private string name;
        private int salary;
        private string address;
        public Employee()
        {
            this.name = "Unknown";
            this.salary = 30000;
            this.address = "Mukalla";
            Console.WriteLine("Welcome to our company");

        }
        public Employee(string name, int salary, string address)
        {
            this.name = name;
            this.salary = salary;
            this.address = address;
        }
        public Employee(string name) : this()
        {
            this.name = name;
        }
        public Employee(int salary) : this()
        {
            this.salary = salary;
        }
        public Employee(int salarty,string address) : this()
        {
            this.address = address;
        }
        public void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.salary);
            Console.WriteLine(this.address);
        }
    }
}
