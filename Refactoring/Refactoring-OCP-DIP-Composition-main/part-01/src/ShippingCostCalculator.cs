namespace RefactoringLab;

public interface IShippingCarrier
{
    decimal CalculateCost(decimal weightKg);

}

public class AramexCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 12m;

}

public class FedExCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 15m;

}

public class DHLCarrier : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 18m;

}

public abstract class ShippingCostCalculator
{

    protected abstract IShippingCarrier CreateCarrier();

    public decimal Calculate(decimal weightKg)
    {
        if (weightKg <= 0)
            throw new ArgumentException("Weight cannot be negative");

        IShippingCarrier carrier = CreateCarrier();

        return carrier.CalculateCost(weightKg);
    }



    // bad implementation that violate ocp and lack polymorphism
    //public decimal Calculate(string carrier, decimal weightKg)
    //{
    //    switch (carrier)
    //    {
    //        case "Aramex":
    //            return weightKg * 12m;
    //        case "FedEx":
    //            return weightKg * 15m;
    //        case "DHL":
    //            return weightKg * 18m;
    //        default:
    //            throw new ArgumentException($"Unknown carrier: {carrier}");
    //    }
    //}
}

public class AramexShippingCalculator : ShippingCostCalculator
{
    protected override IShippingCarrier CreateCarrier()
    {
        return new AramexCarrier();
    }
}

public class FedExShippingCalculator : ShippingCostCalculator
{
    protected override IShippingCarrier CreateCarrier()
    {
        return new FedExCarrier();
    }
}

public class DhlShippingCalculator : ShippingCostCalculator
{
    protected override IShippingCarrier CreateCarrier()
    {
        return new DHLCarrier();
    }
}



