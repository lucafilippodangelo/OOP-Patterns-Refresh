using System;
using System.Collections.Generic;
using System.Text;

//LDVIS004
namespace VisitorBehavioralPattern
{
    public class SantaClaus : IVisitor
    {
        void IVisitor.Visit(IElement v)
        {
            Console.WriteLine("Santa visited " + v.Name);
        }
    }

    public class MailCarrier : IVisitor
    {
        void IVisitor.Visit(IElement v)
        {
            Console.WriteLine("MailCarrier visited " + v.Name);
        }
    }
}
