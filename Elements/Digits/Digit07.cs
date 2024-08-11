using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Digits;

// 7 can be transformed into 1 by giving one matchstick.
internal class Digit07 : ElementBase<string>, ISingleMatchGiver<string>
{
    public override string GetValue()
    {
        return "7";
    }

    public List<ElementBase<string>> Give()
    {
        return new List<ElementBase<string>> { new Digit01() };
    }
}