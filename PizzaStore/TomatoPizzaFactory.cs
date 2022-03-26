using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class TomatoPizzaFactory : PizzaFactory
    {
        private TomatoPizza pizza;        
        public TomatoPizzaFactory(string dough, string sauce, string[] toppings)
        {
            pizza = new TomatoPizza(dough,sauce,toppings);
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing {0} Pizza", pizza.name);
            Console.WriteLine("Tossing {0} Dough", pizza.dough);
            Console.WriteLine("Adding {0} Sauce", pizza.sauce);

            if (pizza.toppings != null && pizza.toppings.Length > 0)
            {
                Console.Write("Adding Toppings: ");
                for (int i = 0; i < pizza.toppings.Length; i++)
                {
                    if (i == pizza.toppings.Length - 1)
                        Console.Write(pizza.toppings[i]);
                    else
                        Console.Write(pizza.toppings[i] + ", ");
                }
                Console.WriteLine();
            }

        }

        public override void bake()
        {
            Console.WriteLine("Baking Pizza for 20 mins at 300");
        }
        public override void cut()
        {
            Console.WriteLine("Cutting the Pizza into slices");
        }
        public override void box()
        {
            Console.WriteLine("Place Pizza in the box");
        }

    }
}
