using System.Linq;
using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Components.Composites
{
    public class Project : Salable
    {
        public Project(string name) : base(name, 1, 0, true)
        {
        }
        
        public Project(string name, int quantity) : base(name, quantity, 0, true)
        {
        }
        
        public Project(string name, int quantity, decimal discount) : base(name, quantity, discount, true)
        {
        }

        public override decimal Price => 0;

        public override decimal subTotal()
        {
            return Salables.Sum(value => value.subTotal()) * Quantity;
        }
    }
}