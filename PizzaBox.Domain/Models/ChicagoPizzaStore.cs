using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class ChicagoPizzaStore : AStore
    {
        //Store location = Chicago
        private Address storeAddress;
        public Address StoreAddress{ get; set; }
        private string storeName = "Chicago Pizza Store";
        public string StoreName{ get; private set; }

    }
}