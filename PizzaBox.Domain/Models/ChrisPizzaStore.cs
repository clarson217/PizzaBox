using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class ChrisPizzaStore : AStore
    {
        
        
        public string StoreName{ get; private set; }

        public ChrisPizzaStore()
        {
            SetName("Chris' Pizza Store");
            StoreAddress = new Address(123, "Main Street", "Pleasantview", "MI", 12345);
        }
    }
}