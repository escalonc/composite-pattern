using CompositePattern.Core;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Products
{
    public class When_calculating_the_subtotal_of_a_product
    {
        private static Salable _product;
        private static decimal _subTotal;
        private Establish context = () =>
        {
            _product = new Product("Ceramic", 3,5,0);
        };

        private Because of = () => { _subTotal = _product.subTotal(); };

        private It should_return_fifteen_usd = () => { _subTotal.Should().Be(15); };
    }
}