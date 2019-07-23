using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Core.Components.Base
{
    public abstract class Salable
    {
        protected IEnumerable<Salable> Salables;

        protected Salable(string name, int quantity, decimal discount, bool isComposite)
        {
            Name = name;
            Quantity = quantity;
            IsComposite = isComposite;
            Discount = discount;
            Salables = Enumerable.Empty<Salable>();
        }

        public string Name { get; }
        
        public abstract decimal Price { get; }
        
        public decimal Quantity { get; }
        
        public decimal Discount { get; }
        
        public bool IsComposite { get; }

        public int SubItemsCount => Salables.Count();
        
        public void Add(Salable salable)
        {
            Salables = Salables.Append(salable);
        }


        public abstract decimal subTotal();
    }
}