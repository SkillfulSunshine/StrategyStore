namespace StrategyStore.Promotions;

public class FixedDiscount : IPromotionStrategy
{
    private readonly decimal _discountAmount;

    public FixedDiscount(decimal discountAmount)
    {
        _discountAmount = discountAmount;
    }

    public decimal ApplyDiscount(decimal originalPrice)
    {
        return originalPrice - _discountAmount;
    }
}
