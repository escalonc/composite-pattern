using CompositePattern.Core;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs
{
    class When_adding_a_product_to_a_kit
    {
        private static Salable _kit;
        private static int _itemsCount;
                
        private Establish context = () =>
        {
            _kit = new Kit("Kitchen", 2500);
            _kit.Add(new Product("Ceramic", (decimal)182.5,6));
        };
        
        private Because of = () =>
        {
            _itemsCount = _kit.SubItemsCount;
        };
        
        private It should_contains_one_product = () => _itemsCount.Should().Be(1);
    }
}