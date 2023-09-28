namespace StrategyStore.Promotions;

public class PercentageDiscount : IPromotionStrategy
{
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public decimal ApplyDiscount(decimal originalPrice)
    {
        return originalPrice - (originalPrice * _percentage / 100);
    }
}
