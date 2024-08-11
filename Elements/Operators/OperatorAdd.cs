using MatchesRiddleSolver.Elements.Digits;
using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Operators;

// Operator + can be transformed to a - by removing one matchstick.
internal class OperatorAdd : ElementBase<string>, ISingleMatchGiver<string>
{
    public override string GetValue()
    {
        return "+";
    }

    public List<ElementBase<string>> Give()
    {
        return new List<ElementBase<string>> { new OperatorSubtract() };
    }
}