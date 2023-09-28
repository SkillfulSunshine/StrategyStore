namespace StrategyStore.Payments;

public class PayPalPayment : IPaymentStrategy
{
    private readonly string _email;
    private readonly CurrencyCodes _currency;

    public PayPalPayment(string email, CurrencyCodes currency)
    {
        _email = email;
        _currency = currency;
    }

    public CurrencyCodes Currency => _currency;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {_currency.GetCurrencySymbol()}{amount} using PayPal account ({_email})");
    }
}
