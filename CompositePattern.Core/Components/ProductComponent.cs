using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Components
{
    public class ProductComponent : ISalableComponent
    {
        public ProductComponent(string name, decimal price)
        {
            Name = name;
            Price = price;
            Quantity = 1;
            Discount = 0;
            IsComposite = false;
            SubItemsCount = 0;
        }
        
        public ProductComponent(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = 0;
            IsComposite = false;
            SubItemsCount = 0;
        }
        
        public ProductComponent(string name, decimal price, int quantity, decimal discount)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = discount;
            IsComposite = false;
            SubItemsCount = 0;
        }


        public string Name { get; }
        
        public decimal Price { get; }
        
        public decimal Quantity { get; }
        
        public decimal Discount { get; }
        
        public bool IsComposite { get; }
        
        public int SubItemsCount { get; }
        
        public void Add(ISalableComponent salableComponent)
        {
            throw new System.NotImplementedException();
        }

        public decimal SubTotal => Price * Quantity;
    }
}