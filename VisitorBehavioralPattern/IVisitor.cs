using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorBehavioralPattern
{
    //LDVIS003
    public interface IVisitor
    {
        void Visit(IElement e);
    }
}
