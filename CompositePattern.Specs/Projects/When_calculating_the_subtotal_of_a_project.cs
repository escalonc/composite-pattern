using CompositePattern.Core;
using CompositePattern.Core.Components;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Projects
{
    public class When_calculating_the_subtotal_of_a_project
    {
        private static Salable _firstProduct;
        private static Salable _secondProduct;
        private static Salable _kitchenKits;
        private static Salable _projectSweetHome;
        
        private static decimal _subTotal;
        private Establish context = () =>
        {
            _firstProduct = new Product("Ceramic", 3,5,0);
            _secondProduct = new Product("Furniture", 100,1,0);
            
            _kitchenKits = new Kit("Kitchen Kit", 2);
            
            _kitchenKits.Add(_firstProduct);
            _kitchenKits.Add(_secondProduct);
            
            _projectSweetHome = new Project("Sweet Home");
            _projectSweetHome.Add(_kitchenKits);
        };

        private Because of = () => { _subTotal = _kitchenKits.subTotal(); };

        private It should_return_two_hundred_and_thirty_usd = () => { _subTotal.Should().Be(230); };
    }
}