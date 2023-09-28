namespace StrategyStore.Promotions;

public interface IPromotionStrategy
{
    decimal ApplyDiscount(decimal originalPrice);
}
