using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Core.Components.Base
{
    public interface ISalableComponent
    {
        string Name { get; }
        
        decimal Price { get; }
        
        decimal Quantity { get; }
        
        decimal Discount { get; }
        
        bool IsComposite { get; }

        int SubItemsCount { get; }

        decimal SubTotal { get; }
        
        void Add(ISalableComponent salableComponent);
    }
}