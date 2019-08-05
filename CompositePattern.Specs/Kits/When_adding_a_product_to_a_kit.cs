using CompositePattern.Core.Components;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Kits
{
    class When_adding_a_product_to_a_kit
    {
        private static ISalableComponent _kit;
        private static int _itemsCount;
                
        private Establish context = () =>
        {
            _kit = new ProductComposite("Kitchen", 1, 0M, true);
            _kit.Add(new ProductComposite("Ceramic", 182.5M,6));
        };
        
        private Because of = () =>
        {
            _itemsCount = _kit.SubItemsCount;
        };
        
        private It should_contains_one_product = () => _itemsCount.Should().Be(1);
    }
}