using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    //enum PizzaSize {Small = 0, Medium = 1, Large = 2}
    public abstract class APizza
    {
        //PizzaSize pizzaSize;
        
        public List<Topping> Toppings { get; set; }
        
        public Size Size { get; set; }
        
        public Crust Crust { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public APizza()
        {
            PizzaFactory();
        }
        /// <summary>
        /// 
        /// </summary>
        private void PizzaFactory()
        {
            AddCrust();
            AddSize();
            AddToppings();
        }
        protected abstract void AddCrust();
        protected abstract void AddSize();
        protected abstract void AddToppings();
    }
}