using PizzaBox.Domain.Models;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace PizzaBox.Domain.Abstracts
{
    [Serializable()]
    [XmlInclude(typeof(MeatPizza))]
    [XmlInclude(typeof(CustomPizza))]
    [XmlInclude(typeof(VeganPizza))]
    [XmlInclude(typeof(VeggiePizza))]
    //enum PizzaSize {Small = 0, Medium = 1, Large = 2}
    public class APizza
    {
        //PizzaSize pizzaSize;
        public double PizzaCost { get; set; }
        public string ThisName { get; set; }
        public List<Topping> Toppings = new List<Topping>();
        
        public Size ThisSize { get; set; }
        public Crust ThisCrust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public APizza()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        
        protected void AddCrust(string crustType, double cost)
        {
            ThisCrust = new Crust(crustType, cost);
        }
        protected void AddSize(string size, double cost)
        {
            ThisSize = new Size(size, cost);
        }
        protected void CalculatePizzaCost()
        {
            PizzaCost = (ThisSize.Price + (ThisCrust.Price) + (.5 * Toppings.Count));
        }
        public double GetPizzaCost()
        {
            return PizzaCost;
        }
        public override string ToString()
        {
            return (ThisSize.Name + " "+ ThisName + "\n" + ThisCrust.Name + "   $" + PizzaCost);
        }
        //PizzaCost = (sizeCost + (crustCost * .7) + 1.0);
    }
}