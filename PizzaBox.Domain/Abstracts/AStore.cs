using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;
using System.IO;
using System.Xml.Serialization;



namespace PizzaBox.Domain.Abstracts
{
    [XmlInclude(typeof(ChicagoPizzaStore))]
    [XmlInclude(typeof(FreddyPizzaStore))]
    [XmlInclude(typeof(DetroitPizzaStore))]
    [XmlInclude(typeof(NewYorkPizzaStore))]
    public abstract class AStore
    {
        private Address storeAddress;
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name;
        }
        private string name;
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }
    }
}