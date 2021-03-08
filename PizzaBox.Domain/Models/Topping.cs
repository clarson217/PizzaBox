using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Topping : APizzaComponent
    {
        public Topping(string toppingType, double cost){
            Name = toppingType;
            Price = cost;
        }
    }
}