using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorStructuralPattern
{
    //LDDEC003
    //LD The Topping abstract class is the parent class of all the decorators. 
    // In its constructor it assigns the parameter of type IComponent to the input variable, which points to the object 
    // to be decorated.
    public abstract class Topping : IComponent
    {
        protected IComponent input;

        public Topping(IComponent i)
        {
            input = i;  //store the item to be decorated
        }

        void IComponent.AddTopping()
        {
        }
    }
}
