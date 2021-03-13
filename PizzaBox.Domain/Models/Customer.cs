using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Customer
    {
        //Customer should open an order
        //Give their name, address
        //
        private string customerName;
        public string CustomerName { get; set; }
        private Address customerAddress;
        public Address CustomerAddress{ get; set; }
        private List<Order> orderHistory;

        
    }
}