using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeStructuralPattern
{
    class ConcreteImplementations
    {
    }

    //concrete implementation
    public class TV : IAppliance
    {
        private string name;

        public TV(string name)
        {
            this.name = name;
        }

        void IAppliance.Run()
        {
            Console.WriteLine(this.name + " is running");
        }
    }

    //concrete implementation
    public class VaccumCleaner : IAppliance
    {
        private string name;

        public VaccumCleaner(string name)
        {
            this.name = name;
        }

        void IAppliance.Run()
        {
            Console.WriteLine(this.name + " is running");
        }
    }
}
