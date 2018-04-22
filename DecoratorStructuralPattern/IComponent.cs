using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorStructuralPattern
{
    //LDDEC001
    //LD The IComponent interface has the AddTopping method that all the classes implement.
    public interface IComponent
    {
        void AddTopping();
    }
}
