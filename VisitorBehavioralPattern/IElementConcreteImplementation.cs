using System;
using System.Collections.Generic;
using System.Text;

//LDVIS002
namespace VisitorBehavioralPattern
{
    public class Household : IElement
    {
        private string name;

        string IElement.Name
        {
            get { return name; }
            set { name = value; }
        }

        public Household(string name)
        {
            this.name = name;
        }

        void IElement.Accept(IVisitor v)
        {
            v.Visit(this); //LD the visitor will apply the logic for the element
        }
    }

    public class BusinessEntity : IElement
    {
        private string name;

        string IElement.Name
        {
            get { return name; }
            set { name = value; }
        }

        public BusinessEntity(string name)
        {
            this.name = name;
        }

        void IElement.Accept(IVisitor v)
        {
            v.Visit(this); //LD the visitor will apply the logic for the element
        }
    }
}
