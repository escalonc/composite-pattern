using System.Linq;
using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Components.Composites
{
    public class Kit : Salable
    {
        public Kit(string name) : base(name, 1, 0, false)
        {
            
        }
        
        public Kit(string name, int quantity) : base(name, quantity, 0, false)
        {
            
        }
        
        public Kit(string name, int quantity, decimal discount) : base(name, quantity, discount, false)
        {
            
        }

        public override decimal Price => Salables.Sum(salable => salable.Price);

        public override decimal subTotal()
        {
            return Salables.Sum(value => value.subTotal()) * Quantity;
        }
    }
}