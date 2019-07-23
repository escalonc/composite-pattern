using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Core
{
    public abstract class Salable
    {
        protected IEnumerable<Salable> _salables;

        protected Salable(string name, int quantity, decimal discount, bool isComposite)
        {
            Name = name;
            Quantity = quantity;
            IsComposite = isComposite;
            Discount = discount;
            _salables = new List<Salable>();
        }

        public string Name { get; }
        
        public abstract decimal Price { get; }
        
        public decimal Quantity { get; }
        
        public decimal Discount { get; }
        
        public bool IsComposite { get; }

        public int SubItemsCount => _salables.Count();
        
        public void Add(Salable salable)
        {
            _salables = _salables.Append(salable);
        }


        public abstract decimal subTotal();
    }
}