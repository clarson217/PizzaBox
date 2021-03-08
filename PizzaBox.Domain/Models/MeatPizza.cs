using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    
    public class MeatPizza : APizza
    {
        protected override void AddCrust(string crustType, double crustCost)
        {
            Crust = new Crust(crustType, crustCost);
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
        public MeatPizza(string crustType, double crustCost, string size, double sizeCost)
        {
            Crust = new Crust(crustType, crustCost);
            Size = new Size(size, sizeCost);
            Toppings[0] = new Topping("Pepperoni", 0.0);
            Toppings[1] = new Topping("Italian Sausage", 0.0);
            Toppings[2] = new Topping("Ham", 0.0);
            Toppings[3] = new Topping("Bacon", 0.0);
        }
        
    }
}