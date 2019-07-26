using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Services
{
    public interface IInvoiceService
    {
        decimal Calculate(decimal discount, params ISalableComponent[] salableComponents);
    }
}