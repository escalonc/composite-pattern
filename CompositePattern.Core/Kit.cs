namespace CompositePattern.Core
{
    public class Kit : Salable
    {
        public Kit(string name, decimal price) : base(name, price, 1, 0, false)
        {
        }
        
        public Kit(string name, decimal price, int quantity) : base(name, price, quantity, 0, false)
        {
        }
        
        public Kit(string name, decimal price, int quantity, decimal discount) : base(name, price, quantity, discount, false)
        {
        }
    }
}