using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    //LDAF005
    //concrete product
    public class RedAdvertiser : IAdvertiser
    {
        void IAdvertiser.Advertise()
        {
            Console.WriteLine("Advertised by RedAdvertiser");
        }
    }

    //concrete product
    public class BlueAdvertiser : IAdvertiser
    {
        void IAdvertiser.Advertise()
        {
            Console.WriteLine("Advertised by BlueAdvertiser");
        }
    }

}
