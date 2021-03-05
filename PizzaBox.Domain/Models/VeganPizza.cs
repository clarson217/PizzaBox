using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class VeganPizza : APizza
    {
        //Build a Vegan Pizza
        protected override void AddCrust()
        {
            throw new System.NotImplementedException();
        }
        protected override void AddSize()
        {
            throw new System.NotImplementedException();
        }
        protected override void AddToppings()
        {
            throw new System.NotImplementedException();
        }
    }
}