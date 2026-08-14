namespace LegacyShop.Api.Pricing;

public sealed class MembershipDiscountStrategy : IPricingStrategy
{
    private const decimal GoldDiscount = 0.85m;
    private const decimal SilverDiscount = 0.92m;

    public decimal Apply(
        decimal currentPrice,
        int quantity,
        string membershipLevel)
    {
        if (membershipLevel == "GOLD")
        {
            return currentPrice * GoldDiscount;
        }

        if (membershipLevel == "SILVER")
        {
            return currentPrice * SilverDiscount;
        }

        return currentPrice;
    }
}