using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyStructuralPattern
{
    //LDPROXY003
    public class ProxyCar : ICar
    {
        private Driver driver;

        //LDPROXY004
        private ICar realCar;

        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            realCar = new Car();
        }

        //LDPROXY005
        void ICar.MoveCar()
        {
            if (driver.Age <= 16)
                Console.WriteLine("Sorry the driver is too young to drive");
            else
                realCar.MoveCar();
        }
    }

}
