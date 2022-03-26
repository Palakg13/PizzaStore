using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    abstract class PizzaFactory
    {
        public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();
       
    }
}
