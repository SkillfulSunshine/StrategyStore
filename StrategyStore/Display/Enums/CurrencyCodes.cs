namespace StrategyStore.Display.Enums;

public enum CurrencyCodes
{
    [Description("EUR")]
    [CurrencySymbol("€")]
    Euro,
    [Description("USD")]
    [CurrencySymbol("$")]
    UnitedStatesDollar,
    [Description("GBP")]
    [CurrencySymbol("£")]
    PoundSterling,
    [Description("AUD")]
    [CurrencySymbol("A$")]
    AustralianDollar,
    [Description("INR")]
    [CurrencySymbol("₹")]
    IndianRupee,
    [Description("CAD")]
    [CurrencySymbol("C$")]
    CanadianDollar,
    [Description("ChineseYuan")]
    [CurrencySymbol("¥")]
    ChineseYuan
}
