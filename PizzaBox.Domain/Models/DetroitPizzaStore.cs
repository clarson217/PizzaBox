using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class DetroitPizzaStore : AStore
    {
        //Store location = detroit
        
        public DetroitPizzaStore()
        {
            SetName("Detroit Pizza Store");
            this.storeAddress = new Address(312, "Main Street", "Detroit", "MI", 34512);
        }
    }
}