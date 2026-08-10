namespace LegacyShop.Api.Pricing;

public interface IPricingStrategy
{
    decimal Apply(
        decimal currentPrice,
        int quantity,
        string membershipLevel);
}