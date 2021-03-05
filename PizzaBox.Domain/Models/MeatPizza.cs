using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    
    public class MeatPizza : APizza
    {
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
                new Topping()
            };
        }
        
    }
}