using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class DetroitPizzaStore : AStore
    {
        //Store location = detroit
        
        private string storeName = "Detroit Pizza Store";
        public string StoreName{ get; private set; }
        private Address storeAddress = new Address(312, "Main Street", "Detroit", "MI", 34512);
    }
}