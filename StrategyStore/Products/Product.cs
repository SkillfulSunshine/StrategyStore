namespace StrategyStore.Products;

public class Product
{
    public string Name { get; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void ApplyPromotion(IPromotionStrategy promotion)
    {
        Price = promotion.ApplyDiscount(Price);
    }
}
