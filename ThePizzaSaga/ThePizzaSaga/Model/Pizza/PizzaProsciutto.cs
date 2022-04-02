using System.Collections.Generic;

namespace ThePizzaSaga.Model
{
    public class PizzaProsciutto : Pizza
    {
        public PizzaProsciutto() : base(new List<Ingredient>() {new Basil(), new Cheese(), new Prosciutto()}, PizzaType.Margheritta)
        {
        }
    }
}