using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class VeganPizza : APizza
    {
        //Build a Vegan Pizza
        // protected override void AddCrust(string crustType, double cost)
        // {
        //     crust = new Crust(crustType, cost);
        // }
        // protected override void AddSize(string size, double cost)
        // {
        //     this.size = new Size(size, cost);
        // }
        protected void AddToppings()
        {
            Topping temp = new Topping("Mushrooms", 0.0);
            toppings.Add(temp);
            temp = new Topping("Onions", 0.0);
            toppings.Add(temp);
            temp = new Topping("Green Peppers", 0.0);
            toppings.Add(temp);
            temp = new Topping("Cherry Tomatoes", 0.0);
            toppings.Add(temp);
        }
        public VeganPizza(string crustType, double crustCost, string size, double sizeCost)
        {
            AddCrust(crustType, crustCost);
            AddSize(size, sizeCost);
            AddToppings();
            CalculatePizzaCost();
            name = "Vegan Pizza";
        }
    }
}