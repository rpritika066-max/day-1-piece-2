namespace LegacyShop.Api.Pricing;

public interface IPricingEngine
{
    decimal CalculateLinePrice(
        decimal price,
        int quantity,
        string membershipLevel);
}