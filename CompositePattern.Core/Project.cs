namespace CompositePattern.Core
{
    public class Project : Salable
    {
        public Project(string name, decimal price) : base(name, price, 1, 0, true)
        {
        }
        
        public Project(string name, decimal price, int quantity) : base(name, price, quantity, 0, true)
        {
        }
        
        public Project(string name, decimal price, int quantity, decimal discount) : base(name, price, quantity, discount, true)
        {
        }
    }
}