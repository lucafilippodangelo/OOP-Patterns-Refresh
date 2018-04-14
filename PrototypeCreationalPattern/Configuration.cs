using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrototypeCreationalPattern
{
    //LDPRT001
    public class Configuration : IPrototype
    {
        private string fileInformation;

        public void GetFileInformation()
        {
            Thread.Sleep(5000);  //takes 5 seconds to get information
            fileInformation = "Long file information";
        }

        IPrototype IPrototype.Clone()
        {
            Configuration c = new Configuration();   //create new object
            c.fileInformation = this.fileInformation; //copy value
            return c;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Showing " + fileInformation);
        }
    }
}
