using System;
using System.Collections.Generic;
using System.Text;


namespace PrototypeCreationalPattern
{
    //LDPRT003
    public class PrototypeManager
    {
        public static void Main(string[] args)
        {
        }

        //dictionary that holds the list of prototypes
        private Dictionary<int, IPrototype> list = new Dictionary<int, IPrototype>();

        public void AddPrototype(IPrototype p, int index)
        {
            list.Add(index, p);  //add prototype to collection
        }

        public IPrototype GetPrototype(int index)
        {
            //return prototype from collection
            return list[index].Clone();
        }
    }
}
