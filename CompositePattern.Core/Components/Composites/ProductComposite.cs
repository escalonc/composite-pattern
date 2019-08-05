using System.Collections.Generic;
using System.Linq;
using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Components.Composites
{
    public class ProductComposite : ISalableComponent
    {
        private IEnumerable<ISalableComponent> _salables;
        private readonly decimal _price;

        public ProductComposite(string name, decimal price, int quantity)
        {
            Name = name;
            _price = price;
            Quantity = quantity;
            Discount = 0;
            IsComposite = false;
            _salables = Enumerable.Empty<ISalableComponent>();
        }
        
        public ProductComposite(string name, decimal price, int quantity, decimal discount)
        {
            Name = name;
            _price = price;
            Quantity = quantity;
            Discount = discount;
            IsComposite = false;
            _salables = Enumerable.Empty<ISalableComponent>();
        }
        
        public ProductComposite(string name, int quantity, decimal discount, bool isComposite)
        {
            Name = name;
            Quantity = quantity;
            Discount = discount;
            IsComposite = isComposite;
            _salables = Enumerable.Empty<ISalableComponent>();
        }
        

        public string Name { get; }

        public decimal Price
        {
            get { return IsComposite ? _salables.Sum(salable => salable.Price) : _price; }
        }

        public decimal Quantity { get; }
        
        public decimal Discount { get; }
        
        public bool IsComposite { get; }

        public int SubItemsCount => _salables.Count();
        
        public void Add(ISalableComponent salableComponent)
        {
            _salables = _salables.Append(salableComponent);
        }

        public decimal SubTotal
        {
            get
            {
                if (!IsComposite)
                {
                    return (Price * Quantity) - Discount;
                }

                return (_salables.Sum(salable => salable.SubTotal) * Quantity) - Discount;
            }
        }
    }
}