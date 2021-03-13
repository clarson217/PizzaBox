using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class ChrisPizzaStore : AStore
    {
        public Address StoreAddress{ get; set; }
        private string storeName = "Chris' Pizza Store";
        public string StoreName{ get; private set; }
    }
}