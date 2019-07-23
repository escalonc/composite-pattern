using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Components
{
    public class Product : Salable
    {
        public Product(string name, decimal price) : base(name, 1,0, false)
        {
            Price = price;
        }
        
        public Product(string name, decimal price, int quantity) : base(name, quantity,0, false)
        {
            Price = price;
        }
        
        public Product(string name, decimal price, int quantity, decimal discount) : base(name, quantity, discount, false)
        {
            Price = price;
        }

        public override decimal Price { get; }

        public override decimal subTotal()
        {
            return Price * Quantity;
        }
    }
}