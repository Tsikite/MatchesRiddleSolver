using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 3 can be transformed into 2 by self exchanging one matchstick.
// 3 can be transformed into 5 by self exchanging one matchstick.
// 3 can be transformed into 9 by receiving one matchstick.
internal class Digit03 : ElementBase<string>, ISingleMatchSelfExchange<string>, ISingleMatchReceiver<string>
{
    public override string GetValue()
    {
        return "3";
    }

    public List<ElementBase<string>> Exchange()
    {
        return new List<ElementBase<string>> { new Digit02(), new Digit05() };
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new Digit09() };
    }
}