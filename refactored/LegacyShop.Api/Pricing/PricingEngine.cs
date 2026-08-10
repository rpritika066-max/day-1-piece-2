namespace LegacyShop.Api.Pricing;

public sealed class PricingEngine(
    IEnumerable<IPricingStrategy> strategies) : IPricingEngine
{
    public decimal CalculateLinePrice(
        decimal price,
        int quantity,
        string membershipLevel)
    {
        var linePrice = price * quantity;

        foreach (var strategy in strategies)
        {
            linePrice = strategy.Apply(
                linePrice,
                quantity,
                membershipLevel);
        }

        return linePrice;
    }
}