namespace StrategyStore.Display;

public class SymbolMessageDisplay : IMessageDisplayStrategy
{
    public string GetMessage(decimal amount, CurrencyCodes currency)
    {
        return $"Paid {currency.GetCurrencySymbol()}{amount:N2}";
    }
}
