using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class CheesePizza :Pizza
    {
        private readonly string _name;
        private string _dough;
        private string _sauce;
        private string[] _toppings;
        public CheesePizza(string dough, string sauce, string[] toppings)
        {
            _name = "Cheese";
            _dough = dough;
            _sauce = sauce;
            _toppings = toppings;
        }
        public override string name
        {
            get { return _name; }
        }

        public override string dough
        {
            get { return _dough; }
            set { _dough = value; }
        }
        public override string sauce
        {
            get { return _sauce; }
            set { _sauce = value; }
        }
        public override string[] toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }
    }
}
