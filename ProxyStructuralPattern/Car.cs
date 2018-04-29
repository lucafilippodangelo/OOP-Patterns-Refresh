using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyStructuralPattern
{
    //LDPROXY006 - the real object
    public class Car : ICar
    {
        void ICar.MoveCar()
        {
            Console.WriteLine("Car has been driven");
        }
    }
}
