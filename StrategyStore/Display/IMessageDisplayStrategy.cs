namespace StrategyStore.Display;

public interface IMessageDisplayStrategy
{
    string GetMessage(decimal amount, CurrencyCodes currency);
}
