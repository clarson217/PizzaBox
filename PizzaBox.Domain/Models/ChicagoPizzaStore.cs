using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class ChicagoPizzaStore : AStore
    {
        //Store location = Chicago
        
        private string storeName = "Chicago Pizza Store";
        public string StoreName{ get; private set; }
        private Address storeAddress = new Address(231, "Main Street", "Chicago", "IL", 23451);
    }
}