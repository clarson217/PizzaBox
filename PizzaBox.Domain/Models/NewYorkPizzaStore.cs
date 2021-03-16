using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class NewYorkPizzaStore : AStore
    {
        //Store location = New York
        
        private string storeName = "New York Pizza Store";
        public string StoreName{ get; private set; }
        private Address storeAddress = new Address(123, "Main Street", "New York City", "New York", 45123);
    }
}