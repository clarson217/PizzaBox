using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class AStore
    {
        public List<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name;
        }
        private string name;
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }
    }
}