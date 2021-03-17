using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    //temporarily abstract!!
    //!! MUST FIX
    public class VeggiePizza : APizza
    {
        //Build a Veggie Pizza
        // protected void AddCrust(string crustType, double cost)
        // {
        //     crust = new Crust(crustType, cost);
        // }
        // protected void AddSize(string size, double cost)
        // {
        //     this.size = new Size(size, cost);
        // }
        protected void AddToppings()
        {
            Topping temp = new Topping("Spinach", 0.0);
            Toppings.Add(temp);
            temp = new Topping("Onions", 0.0);
            Toppings.Add(temp);
            temp = new Topping("Olives", 0.0);
            Toppings.Add(temp);
            temp = new Topping("Banana Peppers", 0.0);
            Toppings.Add(temp);
        }
        public VeggiePizza(string crustType, double crustCost, string size, double sizeCost)
        {
            AddCrust(crustType, crustCost);
            AddSize(size, sizeCost);
            AddToppings();
            CalculatePizzaCost();
            ThisName = "Veggie Pizza";
        }
        public VeggiePizza()
        {
            AddCrust("Regular", 0.0);
            AddSize("small", 0.0);
            ThisName = "Veggie Pizza";
        }
    }
}