using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 0 can be transformed into 6 by self exchanging one matchstick.
// 0 can be transformed into 8 by receiving one matchstick.
// 0 can be transformed into 9 by self exchanging one matchstick.
internal class Digit00 : ElementBase<string>, ISingleMatchSelfExchange<string>, ISingleMatchReceiver<string>
{
    public override string GetValue()
    {
        return "0";
    }

    public List<ElementBase<string>> Exchange()
    {
        return new List<ElementBase<string>> { new Digit06(), new Digit09() };
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new Digit08() };
    }
}