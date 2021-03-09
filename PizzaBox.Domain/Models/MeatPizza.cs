using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    
    public class MeatPizza : APizza
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
            
            Toppings = new List<Topping>
            {
                new Topping("", 0.0),
                new Topping("", 0.0),
                new Topping("", 0.0),
                new Topping("", 0.0)
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