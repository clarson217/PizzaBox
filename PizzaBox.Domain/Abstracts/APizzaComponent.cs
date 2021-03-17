using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    /// <summary>
    /// Component info for pizza components
    /// </summary>
    [Serializable()]
    [XmlInclude(typeof(Topping))]
    [XmlInclude(typeof(Size))]
    [XmlInclude(typeof(Crust))]
    public abstract class APizzaComponent
    {
        public string Name { get; set; }
        public double Price{ get; set; }
    }
}