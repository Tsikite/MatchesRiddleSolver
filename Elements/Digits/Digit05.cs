using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 5 can be transformed into 3 by self exchanging one matchstick.
// 5 can be transformed into 6 by receiving one matchstick.
// 5 can be transformed into 9 by receiving one matchstick.
internal class Digit05 : ElementBase<string>, ISingleMatchSelfExchange<string>, ISingleMatchReceiver<string>
{
    public override string GetValue()
    {
        return "5";
    }

    public List<ElementBase<string>> Exchange()
    {
        return new List<ElementBase<string>> { new Digit03() };
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new Digit06(), new Digit09() };
    }
}