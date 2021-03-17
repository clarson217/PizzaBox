using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class NewYorkPizzaStore : AStore
    {
        //Store location = New York
        
        public NewYorkPizzaStore()
        {
            SetName("New York Pizza Store");
            this.storeAddress = new Address(123, "Main Street", "New York City", "New York", 45123);
        }
    }
}