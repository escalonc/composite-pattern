using CompositePattern.Core;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Kits
{
    class When_adding_a_kit_to_a_project
    {
        private static Salable _project;
        private static int _itemsCount;
                
        private Establish context = () =>
        {
            _project = new Project("Kitchen", 5000);
            _project.Add(new Kit("Kitchen", 182.5M));
        };
        
        private Because of = () =>
        {
            _itemsCount = _project.SubItemsCount;
        };
        
        private It should_contains_one_kit = () => _itemsCount.Should().Be(1);
    }
}