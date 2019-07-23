using CompositePattern.Core;
using CompositePattern.Core.Components;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Kits
{
    public class When_calculating_the_subtotal_of_a_kit
    {
        private static Salable _firstProduct;
        private static Salable _secondProduct;
        private static Salable _kitchenKit;
        
        private static decimal _subTotal;
        private Establish context = () =>
        {
            _firstProduct = new Product("Ceramic", 3,5,0);
            _secondProduct = new Product("Furniture", 100,1,0);
            
            _kitchenKit = new Kit("Kitchen Kit", 0);
            
            _kitchenKit.Add(_firstProduct);
            _kitchenKit.Add(_secondProduct);
        };

        private Because of = () => { _subTotal = _kitchenKit.subTotal(); };

        private It should_return_one_hundred_and_fifteen_usd = () => { _subTotal.Should().Be(115); };
    }
}