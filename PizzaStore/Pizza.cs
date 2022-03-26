using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    abstract class Pizza
    {
        public abstract string name { get; }
        public abstract string dough { get; set; }
        public abstract string sauce { get; set; }
        public abstract string[] toppings { get; set; }
    }
}
