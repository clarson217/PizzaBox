using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        //Chooses the pizza type
        //  Pizza will need size, type, numToppings, etc
        //middleman between the store 
        //and the customer
        //  Holds necessary customer info for the store
        //      Name, number, payment info, address
        //      Order total logistics
        public List<APizza> MyProperty { get; set; }
        public Address OrderAddress { get; set; }
        public AStore PizzaStore { get; set; }
        public Order(){}
    }
}