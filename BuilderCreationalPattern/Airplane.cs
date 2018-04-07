using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCreationalPattern
{
    public class Airplane
    {
        private string BodySpecification;
        private string WingSpecification;

        public string Body
        {
            get { return BodySpecification; }
            set { BodySpecification = value; }
        }

        public string Wing
        {
            get { return WingSpecification; }
            set { WingSpecification = value; }
        }

        //show the airplane
        public void Show()
        {
            Console.WriteLine(Body);
            Console.WriteLine(Wing);
        }
    }
}
