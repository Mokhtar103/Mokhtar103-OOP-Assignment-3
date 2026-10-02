using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src
{
    // new carrier
    public class ExpressCarrier : IShippingCarrier
    {
        public decimal CalculateCost(decimal weightKg) => weightKg * 21m;
    }

    public class ExpressShippingCalculator : ShippingCostCalculator
    {
        protected override IShippingCarrier CreateCarrier()
        {
            return new ExpressCarrier();
        }
    }
}
