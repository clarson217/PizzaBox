using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System;

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
        private readonly string _orderPath = @"order.xml";
        public string _OrderPath { get; private set; }
        private List<APizza> myPizzas;
        private Customer orderCustomer;
        private APizza pizzaStore;
        public List<APizza> MyPizzas { get; set;  }
        
        private string PizzaLister(){
            string pizzaString = "";
            for(int i = 0; i <= myPizzas.Count; i++)
            {
                pizzaString = pizzaString + myPizzas[1].ToString() + "\n";
                
            }
            pizzaString = pizzaString + "\n**********************";
            return pizzaString;
        }
        public Customer OrderCustomer { get; set; }
        public AStore PizzaStore { get; set; }
        public Order(Customer customer, AStore store)
        {
            OrderCustomer = customer;
            PizzaStore = store;
            myPizzas = new List<APizza>();
        }
        public Order()
        {
            OrderCustomer = new Customer();
            PizzaStore = new AStore();
            myPizzas = new List<APizza>();
        }
        public void AddPizza(APizza pizza)
        {
            myPizzas.Add(pizza);
        }
        public void SaveOrder()
        {
            //saves the order
        }
        public string GetCustomerName()
        {
            return this.OrderCustomer.CustomerName;
        }
        public string PrintReciept()
        {
            string reciept = "Receipt";
            try{
            reciept = "**********************\n";
            reciept = reciept + PizzaStore.ToReceipt() +
                         "**********************\n";
            reciept = reciept + OrderCustomer.CustomerName+"\n";
            reciept = reciept + OrderCustomer.GetCustomerAddress()+"\n"+
                         "**********************\n";
            reciept = reciept + PizzaLister();
            }catch(NullReferenceException e)
            {
               return "Cannot make receipt.";
            }
            return reciept;
        }
    }
}