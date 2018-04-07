using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCreationalPattern
{
    public interface IManufacturer
    {
        void BuildBody();
        void BuildWing();
        Airplane GetProduct();
    }
}
