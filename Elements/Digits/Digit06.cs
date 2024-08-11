using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 6 can be transformed into 0 by self exchanging one matchstick.
// 6 can be transformed into 5 by giving one matchstick.
// 6 can be transformed into 8 by receiving one matchstick.
// 6 can be transformed into 9 by self exchanging one matchstick.
internal class Digit06 : ElementBase<string>, ISingleMatchGiver<string>, ISingleMatchReceiver<string>, ISingleMatchSelfExchange<string>
{
    public override string GetValue()
    {
        return "6";
    }

    public List<ElementBase<string>> Give()
    {
        return new List<ElementBase<string>> { new Digit05() };
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new Digit08() };
    }

    public List<ElementBase<string>> Exchange()
    {
        return new List<ElementBase<string>> { new Digit00(), new Digit09() };
    }
}