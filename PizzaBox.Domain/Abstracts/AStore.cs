namespace PizzaBox.Domain.Abstracts
{
    public abstract class AStore
    {
        public override string ToString()
        {
            return Name;
        }
        private string name;
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }
    }
}