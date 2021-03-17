using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace PizzaBox.Domain.Models
{
    [Serializable()]
    public class Customer
    {
        //Customer should open an order
        //Give their name, address
        //
        private readonly string _customerPath = @"customer.xml";
        public string _GetCustomerPath()
        {
            return _customerPath;
        }
        
        // private string customerName;
        
        public string CustomerName { get; set; }
        
        // private Address customerAddress;
        
        public Address CustomerAddress{ get; set; }
        
        public string GetCustomerAddress()
        {
            return CustomerAddress.ToString();
        }
        
        public Customer(string name, Address address)
        {
            CustomerName = name;
            CustomerAddress = address;
        }
        public Customer()
        {
            CustomerName = "";
            CustomerAddress = null;
        }
        public string GetCustomerName()
        {
            return CustomerName;
        }
        
    }
}