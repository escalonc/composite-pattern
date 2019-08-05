using CompositePattern.Core.Components;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Products
{
    public class When_calculating_the_subtotal_of_a_product
    {
        private static ISalableComponent _product;
        private static decimal _subTotal;
        private Establish context = () =>
        {
            _product = new ProductComposite("Ceramic", 3,5,0);
        };

        private Because of = () => _subTotal = _product.SubTotal;

        private It should_return_fifteen_usd = () => _subTotal.Should().Be(15);
    }
}