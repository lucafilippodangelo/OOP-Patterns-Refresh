using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCreationalPattern
{
    public class Director
    {
        //LDB001
        public Airplane BuildAirplane(IManufacturer m)
        {
            m.BuildBody();
            m.BuildWing();
            return m.GetProduct();
        }
    }
}
