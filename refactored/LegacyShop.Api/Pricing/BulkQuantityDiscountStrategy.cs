namespace LegacyShop.Api.Pricing;

public sealed class BulkQuantityDiscountStrategy : IPricingStrategy
{
    private const decimal Bulk10Discount = 0.90m;
    private const decimal Bulk5Discount = 0.95m;

    public decimal Apply(
        decimal currentPrice,
        int quantity,
        string membershipLevel)
    {
        if (quantity >= 10)
        {
            return currentPrice * Bulk10Discount;
        }

        if (quantity >= 5)
        {
            return currentPrice * Bulk5Discount;
        }

        return currentPrice;
    }
}