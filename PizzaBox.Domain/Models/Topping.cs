using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace PizzaBox.Domain.Models
{
    [Serializable()]
    public class Topping : APizzaComponent
    {
        public Topping(string toppingType, double cost){
            Name = toppingType;
            Price = cost;
        }
        public Topping()
        {
            Name = "";
            Price = 0.0;
        }
    }
}