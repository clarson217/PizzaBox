using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class DetroitPizzaStore : AStore
    {
        //Store location = detroit
        public Address StoreAddress{ get; set; }
        private string storeName = "Detroit Pizza Store";
        public string StoreName{ get; private set; }
    }
}