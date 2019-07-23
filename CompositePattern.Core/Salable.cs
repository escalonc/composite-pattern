using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Core
{
    public abstract class Salable
    {
        private IEnumerable<Salable> _salables;

        protected Salable(string name, decimal price, int quantity, decimal discount, bool isComposite)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            IsComposite = isComposite;
            Discount = discount;
            _salables = new List<Salable>();
        }

        public string Name { get; }
        
        public decimal Price { get; }
        
        public decimal Quantity { get; }
        
        public decimal Discount { get; }
        
        public bool IsComposite { get; }

        public int SubItemsCount => _salables.Count();
        
        public void Add(Salable salable)
        {
            _salables = _salables.Append(salable);
        }
        

    }
}