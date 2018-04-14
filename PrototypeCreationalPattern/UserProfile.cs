using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrototypeCreationalPattern
{
    //LDPRT002
    public class UserProfile : IPrototype
    {
        private string databaseInformation;

        public void GetDatabaseInformation()
        {
            Thread.Sleep(5000);  //takes 5 seconds to get information
            databaseInformation = "Long database information";
        }

        IPrototype IPrototype.Clone()
        {
            UserProfile p = new UserProfile();  //create new object
            p.databaseInformation = this.databaseInformation; //copy value
            return p;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Showing " + databaseInformation);
        }
    }
}
