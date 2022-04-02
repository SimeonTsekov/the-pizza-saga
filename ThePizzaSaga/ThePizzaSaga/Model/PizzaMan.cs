using System;

namespace ThePizzaSaga.Model
{
    public class PizzaMan
    {
        public Name Name;
        public int PreparationTime;

        public PizzaMan()
        {
            var names = Enum.GetValues(typeof(Name));
            var random = new Random();
            
            Name = (Name)names.GetValue(random.Next(names.Length));
            PreparationTime = random.Next(1, 5);
        }
    }
}