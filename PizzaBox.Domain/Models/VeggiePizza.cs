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