using System;

namespace MyApp
{
    public class PizzaShop
    {
        public readonly string[] Classics = new []
        {
            "Classic Pepperoni"
        };

        public Pizza GetPizza(string classicName) 
        {
            if (!Classics.Contains(classicName))
                throw new ArgumentException($"We don't have a classic named {classicName}");

            return new Pizza (new [] { "pepperoni", "cheese" });
        }

        public Pizza GetPizza(string[] toppings)
        {
            return new Pizza (new [] { "pepperoni" });
        }
    }

    public class Pizza
    {
        public Pizza(string[] toppings) 
        {
            Toppings = toppings;
        }

        public string[] Toppings { get; }
    }
}
