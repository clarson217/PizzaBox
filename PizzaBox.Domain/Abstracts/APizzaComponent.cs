namespace PizzaBox.Domain.Abstracts
{
    /// <summary>
    /// Component info for pizza components
    /// </summary>
    public abstract class APizzaComponent
    {
        public string Name { get; set; }
        public double Price{ get; set; }
    }
}