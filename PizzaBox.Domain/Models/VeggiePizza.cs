using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    //temporarily abstract!!
    //!! MUST FIX
    public class VeggiePizza : APizza
    {
        //Build a Veggie Pizza
        protected override void AddCrust()
        {
            Crust = new Crust();
        }
        protected override void AddSize()
        {
            Size = new Size();
        }
        protected override void AddToppings()
        {
            Toppings = new List<Topping>
            {
                new Topping(),
                new Topping(),
                new Topping(),
                new Topping()
            };
        }
        public VeggiePizza(string crustType, double crustCost, string size, double sizeCost)
        {
            Crust = new Crust(crustType, crustCost);
            Size = new Size(size, sizeCost);
            Toppings[0] = new Topping("Spinach", 0.0);
            Toppings[1] = new Topping("Onions", 0.0);
            Toppings[2] = new Topping("Olives", 0.0);
            Toppings[3] = new Topping("Banana Peppers", 0.0);
        }
    }
}