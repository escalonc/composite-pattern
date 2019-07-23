using CompositePattern.Core;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Projects
{
    class When_adding_a_kit_to_a_project
    {
        private static Salable _project;
        private static int _itemsCount;
                
        private Establish context = () =>
        {
            _project = new Project("Kitchen");
            
            _project.Add(new Kit("Kitchen"));
        };
        
        private Because of = () =>
        {
            _itemsCount = _project.SubItemsCount;
        };
        
        private It should_contains_one_kit = () => _itemsCount.Should().Be(1);
    }
}