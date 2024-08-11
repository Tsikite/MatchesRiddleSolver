using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;
// 2 Can be transformed into 3 by moving one matchstick

internal class Digit02 : ElementBase<string>, ISingleMatchSelfExchange<string>
{
    public override string GetValue()
    {
        return "2";
    }

    public List<ElementBase<string>> Exchange()
    {
        return new List<ElementBase<string>> { new Digit03() };
    }
}