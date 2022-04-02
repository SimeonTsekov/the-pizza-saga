using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace ThePizzaSaga.Model
{
    public class PizzaMargheritta : Pizza
    {
        public PizzaMargheritta() : base(new List<Ingredient>() {new Basil(), new Cheese()}, PizzaType.Margheritta)
        {
        }
    }
}