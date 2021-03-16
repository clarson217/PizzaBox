using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
    public class Size : APizzaComponent
    {
        public Size(string size, double cost){
            if (size == "small" || size == "medium" || size == "large")
            {
                Name = size;
            }
            else
            {
                Name = "small";
            }
            Price = cost;
        }
    }
}