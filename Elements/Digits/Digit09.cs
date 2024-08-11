using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;
// 9 can be transformed into 0 by self exchanging one matchstick.
// 9 can be transformed into 3 by giving one matchstick.
// 9 can be transformed into 5 by giving one matchstick.
// 9 can be transformed into 6 by self exchanging one matchstick.
// 9 can be transformed into 8 by receiving one matchstick.

internal class Digit09 : ElementBase<string>, ISingleMatchSelfExchange<string>, ISingleMatchReceiver<string>, ISingleMatchGiver<string>
{
    public override string GetValue()
    {
        return "9";
    }

    public List<ElementBase<string>> Exchange()
    {
        return new List<ElementBase<string>> { new Digit00(), new Digit06() };
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new Digit08() };
    }

    public List<ElementBase<string>> Give()
    {
        return new List<ElementBase<string>> { new Digit03(), new Digit05() };
    }
}