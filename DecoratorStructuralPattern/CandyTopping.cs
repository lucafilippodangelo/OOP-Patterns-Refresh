using System;

namespace DecoratorStructuralPattern
{
        //LDDEC004
        //LD below a decorator, has its own implementation on how to add the toppings.
        public class CandyTopping : Topping, IComponent
        {
            public CandyTopping(IComponent i) : base(i) {}

            void IComponent.AddTopping()
            {
                input.AddTopping();  //decorate others first
                Console.WriteLine("Candy Topping added");
            }
        }
}
