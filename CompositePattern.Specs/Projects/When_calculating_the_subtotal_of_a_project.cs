using CompositePattern.Core.Components;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Projects
{
    public class When_calculating_the_subtotal_of_a_project
    {
        private static ISalableComponent _firstProduct;
        private static ISalableComponent _secondProduct;
        private static ISalableComponent _kitchenKits;
        private static ISalableComponent _projectSweetHome;
        
        private static decimal _subTotal;
        private Establish context = () =>
        {
            _firstProduct = new ProductComponent("Ceramic", 3,5,0);
            _secondProduct = new ProductComponent("Furniture", 100,1,0);
            
            _kitchenKits = new KitComposite("Kitchen Kit", 2);
            
            _kitchenKits.Add(_firstProduct);
            _kitchenKits.Add(_secondProduct);
            
            _projectSweetHome = new ProjectComposite("Sweet Home");
            _projectSweetHome.Add(_kitchenKits);
        };

        private Because of = () => _subTotal = _kitchenKits.SubTotal;

        private It should_return_two_hundred_and_thirty_usd = () => _subTotal.Should().Be(230);
    }
}