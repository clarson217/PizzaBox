using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Customer
    {
        //Customer should open an order
        //Give their name, address
        //
        private readonly string _customerPath = @"customer.xml";
        public string _CustomerPath { get; private set; }
        private string customerName;
        public string CustomerName { get; set; }
        private Address customerAddress;
        public Address CustomerAddress{ get; set; }
        public string GetCustomerAddress()
        {
            return customerAddress.ToString();
        }
        private List<Order> orderHistory;
        public List<Order> OrderHistory { get; set; }
        public Customer(string name, Address address)
        {
            customerName = name;
            customerAddress = address;
        }
        public Customer()
        {
            customerName = "";
            customerAddress = null;
        }
        
    }
}