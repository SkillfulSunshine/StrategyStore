namespace StrategyStore.Store;

public class ShoppingCart
{
    private readonly IPaymentStrategy _paymentStrategy;
    private readonly IPromotionStrategy _promotionStrategy;
    private readonly IMessageDisplayStrategy _messageDisplayStrategy;

    public ShoppingCart(IPaymentStrategy paymentStrategy, IPromotionStrategy promotionStrategy, IMessageDisplayStrategy messageDisplayStrategy)
    {
        _paymentStrategy = paymentStrategy;
        _promotionStrategy = promotionStrategy;
        _messageDisplayStrategy = messageDisplayStrategy;
    }

    public void Checkout(Product[] products)
    {
        decimal totalAmount = 0;

        foreach (var product in products)
        {
            product.ApplyPromotion(_promotionStrategy);
            totalAmount += product.Price;
        }

        _paymentStrategy.Pay(totalAmount);

        string message = $"Checkout complete - {_messageDisplayStrategy.GetMessage(totalAmount, _paymentStrategy.Currency)}";
        Console.WriteLine(message);
    }
}
