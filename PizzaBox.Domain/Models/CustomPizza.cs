using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class CustomPizza : APizza
    {
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