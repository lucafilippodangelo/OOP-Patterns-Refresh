using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyStructuralPattern
{
    public class Driver
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Driver(int age)
        {
            this.age = age;
        }
    }
}
