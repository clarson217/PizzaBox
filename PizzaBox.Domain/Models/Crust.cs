using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;
namespace PizzaBox.Domain.Models
{
    [Serializable()]
    public class Crust : APizzaComponent
    {
        public Crust(string crustType, double cost){
            Name = crustType;
            Price = cost;
        }
        public Crust()
        {
            Name = "";
            Price = 0.0;
        }
    }
}