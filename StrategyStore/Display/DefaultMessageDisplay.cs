namespace StrategyStore.Display;

public class DefaultMessageDisplay : IMessageDisplayStrategy
{
    public string GetMessage(decimal amount, CurrencyCodes currency)
    {
        return $"Paid {currency.GetCurrencyCode()} {amount}";
    }
}
