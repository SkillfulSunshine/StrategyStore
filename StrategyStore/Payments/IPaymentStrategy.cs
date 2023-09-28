namespace StrategyStore.Payments;

public interface IPaymentStrategy
{
    CurrencyCodes Currency { get; }
    void Pay(decimal amount);
}
