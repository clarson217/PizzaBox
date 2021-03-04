namespace PizzaBox.Domain.Abstracts
{
    enum PizzaSize {Small = 0, Medium = 1, Large = 2}
    public abstract class APizza
    {
        PizzaSize pizzaSize;
        private int numToppings;
        public int NumToppings { get; set; }
        
        private string crustType;
        public string CrustType { get; set; }
    }
}