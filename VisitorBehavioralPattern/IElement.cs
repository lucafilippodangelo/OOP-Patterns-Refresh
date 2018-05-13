using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorBehavioralPattern
{
    //LDVIS001
    public interface IElement
    {
        string Name { get; set; }
        void Accept(IVisitor v);
    }
}
