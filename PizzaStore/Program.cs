using System;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome!!");
            Console.WriteLine("We have following type of Pizzas available: Cheese Pizza, Tomato Pizza, Veg Pizza.");
            Console.WriteLine("Enter the Pizza type you would like to have.");
            Console.WriteLine("Enter Cheese to order Cheese Pizza\nEnter Tomato to order Tomato Pizza\nEnter Veg to order Veg Pizza.");
           
            string pizzaType = Console.ReadLine();

            PizzaFactory factory  = OrderPizza(pizzaType);            
            if (factory != null)
            {
                factory.prepare();
                factory.bake();
                factory.cut();
                factory.box();
                Console.WriteLine("Thanks for visiting us!");
            }
            else
            {
                Console.WriteLine("We don't serve the selected pizza. Please visit us again.");
            }
            Console.ReadKey();
        }

        static PizzaFactory OrderPizza(string pizzaType)
        {
            PizzaFactory factory = null;
            switch (pizzaType.ToLower())
            {
                case "cheese":
                    factory = new CheesePizzaFactory("Thin Crust", "SouthWest", new string[] { "Paneer", "Jalapeno" });
                    break;
                case "tomato":
                    factory = new TomatoPizzaFactory("Regular", "Tomato", new string[] { "Jalapeno", "FreshTomato" });
                    break;
                case "veg":
                    factory = new VegPizzaFactory("CheeseBurst", "Mayo", new string[] { "Capsicum", "Onion", "Jalapeno" });
                    break;
                default:
                    break;
            }
            return factory;
        }
    }
}
