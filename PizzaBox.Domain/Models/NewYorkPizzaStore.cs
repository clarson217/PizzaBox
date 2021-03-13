using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class NewYorkPizzaStore : AStore
    {
        //Store location = New York
        public Address StoreAddress{ get; set; }
        private string storeName = "New York Pizza Store";
        public string StoreName{ get; private set; }
    }
}