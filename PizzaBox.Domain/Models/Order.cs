using PizzaBox.Domain.Abstracts;
using System.Collections.Generic;
using System;
using System.Xml.Serialization;

namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable()]
    public class Order
    {

        private readonly string _orderPath = @"order.xml";
        public string _GetOrderPath()
        {
            return _orderPath;
        }
        
        public List<APizza> MyPizzas { get; set; }
        
        public Customer OrderCustomer { get; set; }

        public AStore PizzaStore { get; set; }
        
        
        private string PizzaLister(){
            string pizzaString = "";
            for(int i = 0; i < MyPizzas.Count; i++)
            {
                pizzaString = pizzaString + MyPizzas[i].ToString() + "\n";
                
            }
            pizzaString = pizzaString + "\n**********************";
            return pizzaString;
        }
        public Order(Customer customer, AStore store)
        {
            OrderCustomer = customer;
            PizzaStore = store;
            MyPizzas = new List<APizza>();
        }
        public Order()
        {
            OrderCustomer = new Customer();
            PizzaStore = new AStore();
            MyPizzas = new List<APizza>();
        }
        public void AddPizza(APizza pizza)
        {
            MyPizzas.Add(pizza);
        }
        public void SaveOrder()
        {
            //saves the order
        }
        public string GetCustomerName()
        {
            return this.OrderCustomer.GetCustomerName();
        }
        public string PrintReciept()
        {
            string reciept = "Receipt";
            reciept =   "**********************\n" + 
                        PizzaStore.ToReceipt() + "\n" +
                        "**********************\n" + 
                        OrderCustomer.GetCustomerName()+"\n" + 
                        OrderCustomer.GetCustomerAddress()+"\n"+
                        "**********************\n" + 
                        PizzaLister();
            return reciept;
        }
    }
}