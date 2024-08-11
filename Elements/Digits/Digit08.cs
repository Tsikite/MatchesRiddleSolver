using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 8 can be transformed into 0 by giving one matchstick.
// 8 can be transformed into 6 by giving one matchstick.
// 8 can be transformed into 9 by giving one matchstick.
internal class Digit08 : ElementBase<string>, ISingleMatchGiver<string>
{
    public override string GetValue()
    {
        return "8";
    }

    public List<ElementBase<string>> Give()
    {
        return new List<ElementBase<string>> { new Digit00(), new Digit06(), new Digit09() };
    }
}