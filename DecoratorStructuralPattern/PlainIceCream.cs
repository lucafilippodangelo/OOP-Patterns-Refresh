using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorStructuralPattern
{
    //LDDEC002
    //LD is the starting point object.
    public class PlainIceCream : IComponent
    {
        void IComponent.AddTopping()
        {
            Console.WriteLine("PLAIN-ICE-CREAM ADD TOPPING METHOD Plain Ice Cream ready for some toppings");
        }
    }
}
