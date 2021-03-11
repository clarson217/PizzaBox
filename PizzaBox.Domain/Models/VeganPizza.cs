using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class VeganPizza : APizza
    {
        //Build a Vegan Pizza
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
        public VeganPizza( string size, double sizeCost)
        {
            Crust = new Crust("Garlic-herb Crust", 0.0);
            Size = new Size(size, sizeCost);
            Toppings[0] = new Topping("Mushrooms", 0.0);
            Toppings[1] = new Topping("Onions", 0.0);
            Toppings[2] = new Topping("Green Peppers", 0.0);
            Toppings[3] = new Topping("Cherry Tomatoes", 0.0);
        }
    }
}