using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;
using System.IO;
using System.Xml.Serialization;



namespace PizzaBox.Domain.Abstracts
{
    [XmlInclude(typeof(ChicagoPizzaStore))]
    [XmlInclude(typeof(ChrisPizzaStore))]
    [XmlInclude(typeof(DetroitPizzaStore))]
    [XmlInclude(typeof(NewYorkPizzaStore))]
    public class AStore
    {
        protected Address storeAddress;
        public Address StoreAddress{ get; set; }
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return name;
        }
        public string ToReceipt()
        {
            return (name + "\n" + storeAddress.ToString());
        }
        private string name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string storeName)
        {
            name = storeName;
        }
    }
}