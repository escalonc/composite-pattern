using System.Xml.Schema;
using CompositePattern.Core.Components;
using CompositePattern.Core.Components.Base;
using CompositePattern.Core.Components.Composites;
using CompositePattern.Core.Services;
using FluentAssertions;
using Machine.Specifications;

namespace CompositePattern.Specs.Invoice
{
    public class When_purchasing_multiple_salables
    {
        private static ISalableComponent _productOne;
        private static ISalableComponent _productTwo;
        private static ISalableComponent _kitchenKit;
        private static ISalableComponent _mySweetHomeProject;
        private static IInvoiceService _invoiceService;
        private static decimal _total;

        private Establish context = () =>
        {
            _invoiceService = new InvoiceService();
            
            _productOne = new ProductComponent("Ceramic", 3,5);
            _productTwo = new ProductComponent("Furniture", 150,1);
            
            _kitchenKit = new KitComposite("Kitchen Kit");
            _kitchenKit.Add(_productTwo);
            
            _mySweetHomeProject = new ProjectComposite("Project");
            _mySweetHomeProject.Add(_kitchenKit);
            
        };

        private Because of = () => _total = _invoiceService.Calculate(0, _productOne, _mySweetHomeProject);

        private It should_return_the_amount_of_165_usd_ = () => _total.Should().Be(165);
    }
}