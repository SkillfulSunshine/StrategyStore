namespace StrategyStore.Payments;

public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;
    private readonly string _name;
    private readonly CurrencyCodes _currency;

    public CreditCardPayment(string cardNumber, string name, CurrencyCodes currency)
    {
        _cardNumber = cardNumber;
        _name = name;
        _currency = currency;
    }

    public CurrencyCodes Currency => _currency;

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {_currency.GetCurrencySymbol()}{amount} using Credit Card ({_cardNumber}) owned by {_name}");
    }
}
