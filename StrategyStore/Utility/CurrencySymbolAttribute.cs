namespace StrategyStore.Utility;

[AttributeUsage(AttributeTargets.Field)]
public class CurrencySymbolAttribute : Attribute
{
    public string Symbol { get; }

    public CurrencySymbolAttribute(string symbol)
    {
        Symbol = symbol;
    }
}
