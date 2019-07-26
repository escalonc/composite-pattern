using System.Collections.Generic;
using System.Linq;
using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Components.Composites
{
    public class ProjectComposite : ISalableComponent
    {
        private IEnumerable<ISalableComponent> _salables;

        public ProjectComposite(string name)
        {
            Name = name;
            Quantity = 1;
            Discount = 0;
            IsComposite = true;
            _salables = Enumerable.Empty<ISalableComponent>();
        }
        
        public ProjectComposite(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
            Discount = 0;
            IsComposite = true;
            _salables = Enumerable.Empty<ISalableComponent>();
        }
        
        public ProjectComposite(string name, int quantity, decimal discount)
        {
            Name = name;
            Quantity = quantity;
            Discount = discount;
            IsComposite = true;
            _salables = Enumerable.Empty<ISalableComponent>();
        }

        public string Name { get; }

        public decimal Quantity { get; }
        
        public decimal Discount { get; }
        
        public bool IsComposite { get; }
        
        public int SubItemsCount => _salables.Count();

        public decimal SubTotal => (_salables.Sum(salable => salable.SubTotal) * Quantity) - Discount;
        
        public decimal Price => _salables.Sum(salable => salable.Price);
        
        public void Add(ISalableComponent salableComponent)
        {
            _salables = _salables.Append(salableComponent);
        }
    }
}