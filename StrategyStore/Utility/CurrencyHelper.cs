namespace StrategyStore.Utility;

public static class CurrencyHelper
{
    public static string GetCurrencyCode(this CurrencyCodes currency)
    {
        var fieldInfo = currency.GetType().GetField(currency.ToString());
        return fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] attributes && attributes.Length > 0
            ? attributes[0].Description
            : currency.ToString();
    }

    public static string GetCurrencySymbol(this CurrencyCodes currency)
    {
        FieldInfo fieldInfo = currency.GetType().GetField(currency.ToString())!;

        if (fieldInfo.GetCustomAttributes(typeof(CurrencySymbolAttribute), false) is CurrencySymbolAttribute[] attributes && attributes.Length > 0)
        {
            return attributes[0].Symbol;
        }

        return string.Empty;
    }
}
