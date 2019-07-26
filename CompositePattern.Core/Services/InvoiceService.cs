using System;
using System.Linq;
using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Services
{
    public class InvoiceService : IInvoiceService
    {
        public decimal Calculate(decimal discount, params ISalableComponent[] salableComponents)
        {
            return (salableComponents.Sum(salable => salable.SubTotal) - discount);
        }
    }
}