using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeCreationalPattern
{
    //LDPRT004
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
