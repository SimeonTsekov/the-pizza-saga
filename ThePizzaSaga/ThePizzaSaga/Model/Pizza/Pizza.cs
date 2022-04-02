using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace ThePizzaSaga.Model
{
    public abstract class Pizza
    {
        protected List<Ingredient> ingredients;
        protected PizzaType Type;

        protected Pizza(List<Ingredient> ingredients, PizzaType type)
        {
            this.ingredients = ingredients;
            Type = type;
        }

        public virtual int CalculatePrice()
        {
            return ingredients.Sum(ingredient => ingredient.Price);
        }


        public virtual int CalculateBakeTime()
        {
            return ingredients.Max(ingredient => ingredient.BakeTime);
        }
    }
}