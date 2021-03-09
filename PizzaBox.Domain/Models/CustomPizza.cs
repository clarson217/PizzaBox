using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.IO;
using System;

namespace PizzaBox.Domain.Models
{
    public class CustomPizza : APizza
    {
        protected override void AddCrust(string crustType, double cost)
        {
            Crust = new Crust(crustType, cost);
        }
        protected override void AddSize(string size, double cost)
        {
            Size = new Size(size, cost);
        }
        protected override void AddToppings()
        {
            /*
            Toppings = new List<Topping>
            {
                new Topping(),
                new Topping(),
                new Topping(),
                new Topping()
            };
            */
        }
        public CustomPizza()
        {
            //prompt user and get (with verification)
            //size, crust type, and toppings (Loop through toppings menu until quit selection)
            Console.WriteLine("What size is your custom pizza? (small, medium, or large)");

        }
    }
}