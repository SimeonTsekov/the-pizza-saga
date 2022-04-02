using System;

namespace ThePizzaSaga.Model
{
    public abstract class Ingredient
    {
        public readonly string Name;
        public readonly int Price;
        public readonly int BakeTime;

        protected Ingredient(string name, int price, int bakeTime)
        {
            Name = name;
            Price = price;
            BakeTime = bakeTime;
        }
    }
}