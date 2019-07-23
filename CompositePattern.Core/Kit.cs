using System.Linq;

namespace CompositePattern.Core
{
    public class Kit : Salable
    {
        public Kit(string name, decimal price) : base(name, 1, 0, false)
        {
            Price = price;
        }
        
        public Kit(string name, decimal price, int quantity) : base(name, quantity, 0, false)
        {
            Price = price;
        }
        
        public Kit(string name, decimal price, int quantity, decimal discount) : base(name, quantity, discount, false)
        {
            Price = price;
        }

        public override decimal Price { get; }

        public override decimal subTotal()
        {
            return _salables.Sum(value => value.subTotal());
        }
    }
}