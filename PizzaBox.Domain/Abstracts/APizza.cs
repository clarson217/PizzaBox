using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    //enum PizzaSize {Small = 0, Medium = 1, Large = 2}
    public class APizza
    {
        //PizzaSize pizzaSize;
        protected double pizzaCost = 0.0;
        protected string name = "";
        protected List<Topping> toppings = new List<Topping>();
        public List<Topping> Toppings { get; set; }
        
        protected Size size;
        
        protected Crust crust;
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
            crust = new Crust(crustType, cost);
        }
        protected void AddSize(string size, double cost)
        {
            this.size = new Size(size, cost);
        }
        protected void CalculatePizzaCost()
        {
            pizzaCost = (size.Price + (crust.Price) + (.5 * toppings.Count));
        }
        public double GetPizzaCost()
        {
            return pizzaCost;
        }
        public override string ToString()
        {
            return (size.Name + " "+ name + "\n" + crust.Name + "   " + pizzaCost);
        }
        //PizzaCost = (sizeCost + (crustCost * .7) + 1.0);
    }
}