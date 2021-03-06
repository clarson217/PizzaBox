using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    
    public class MeatPizza : APizza
    {
        

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
            
            Topping temp = new Topping("Pepperoni", 0.0);
            Toppings.Add(temp);
            temp = new Topping("Italian Sausage", 0.0);
            Toppings.Add(temp);
            temp = new Topping("Ham", 0.0);
            Toppings.Add(temp);
            temp = new Topping("Bacon", 0.0);
            Toppings.Add(temp);
            
        }
        public MeatPizza()
        {
            AddCrust("Regular", 0.0);
            AddSize("small", 0.0);
            ThisName = "Meat Lover's Pizza";
        }
        public MeatPizza(string crustType, double crustCost, string size, double sizeCost)
        {
            AddCrust(crustType, crustCost);
            AddSize(size, sizeCost);
            AddToppings();
            CalculatePizzaCost();
            ThisName = "Meat Lover's Pizza";
        }
        
    }
}