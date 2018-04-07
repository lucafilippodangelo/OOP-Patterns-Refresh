using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCreationalPattern
{
    //LDB002
    public class JetManufacturer : IManufacturer
    {
        private Airplane product = new Airplane();

        public void BuildBody()
        {
            product.Body = "Metal Body for Jet airplane";
        }

        public void BuildWing()
        {
            product.Wing = "Metal Wing for Jet airplane";
        }

        public Airplane GetProduct()
        {
            return product;
        }
    }

    //LDB003
    public class PropellerManufacturer : IManufacturer
    {
        private Airplane product = new Airplane();

        public void BuildBody()
        {
            product.Body = "Wood Body for Propeller airplane";
        }

        public void BuildWing()
        {
            product.Wing = "Wood Wing for Propeller airplane";
        }

        public Airplane GetProduct()
        {
            return product;
        }
    }
}
