namespace PizzaBox.Domain.Models
{
    /// <summary>
    /// Component info for pizza components
    /// </summary>
    public abstract class APizzaComponent
    {
        public string Name { get; set; }
        public decimal Price{ get; set; }
    }
}