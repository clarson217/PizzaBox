using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Singletons
{
    public class StoreSingleton
    {
        public List<AStore> Stores { get; set; }
        public StoreSingleton()
        {
            Stores = new List<AStore>
            {
                new FreddyPizza() {Name = "freddy pizza"},
                new NewYorkPizza() {Name = "New York Pizza"},
                new ChicagoPizza() {Name = "Chicago Pizza"},
                new DetroitPizza() {Name = "Detroit Pizza"}

            };
        }
    }
}  