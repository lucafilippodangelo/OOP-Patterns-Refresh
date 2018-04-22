using System;

namespace DecoratorStructuralPattern
{
    //LDDEC004
    //LD below a decorator, has its own implementation on how to add the toppings.
    public class NutsTopping : Topping, IComponent
        {
            public NutsTopping(IComponent i)
                : base(i)
            {
            }

            void IComponent.AddTopping()
            {
                input.AddTopping();  //decorate others first
                Console.WriteLine("Nuts Topping added");
            }
        }
}
