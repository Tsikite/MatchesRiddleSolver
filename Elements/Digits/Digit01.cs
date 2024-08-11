using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 1 can be transformed into 7 by receiving one matchstick.
internal class Digit01 : ElementBase<string>, ISingleMatchReceiver<string>
{
    public override string GetValue()
    {
        return "1";
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new Digit07() };
    }
}