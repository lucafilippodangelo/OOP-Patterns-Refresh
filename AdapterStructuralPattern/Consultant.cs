using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterStructuralPattern
{
    //LDADP001
    //existing given class does not need to be changed
    public class Consultant
    {
        private string name;

        public Consultant(string name)
        {
            this.name = name;
        }

        protected void ShowSmile()
        {
            Console.WriteLine("Consultant " + this.name + " showed smile");
        }
    }
}
