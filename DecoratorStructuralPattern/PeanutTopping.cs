using System;

namespace DecoratorStructuralPattern
{
    //LDDEC004
    //LD below a decorator, has its own implementation on how to add the toppings.
    public class PeanutTopping : Topping, IComponent
        {
            public PeanutTopping(IComponent i) : base(i) {}

            void IComponent.AddTopping()
            {
                input.AddTopping();  //LDDEC005 make the previous object do the decorations first
                Console.WriteLine("Peanut Topping added"); //LDDEC006 then add the implementation here to add the new feature
        }
        }
  
}
