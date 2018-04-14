using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterStructuralPattern
{
    public class Employee : IEmployee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        void IEmployee.ShowHappiness()
        {
            Console.WriteLine("Employee " + this.name + " showed happiness");
        }
    }

}
