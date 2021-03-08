using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Crust : APizzaComponent
    {
        public Crust(string crustType, double cost){
            Name = crustType;
            Price = cost;
        }
    }
}