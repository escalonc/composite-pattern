using System;
using CompositePattern.Core.Components.Base;

namespace CompositePattern.Core.Services
{
    public class InvoiceService
    {
        public decimal Calculate(params ISalableComponent[] salableComponents)
        {
            throw new NotImplementedException();
        }
    }
}