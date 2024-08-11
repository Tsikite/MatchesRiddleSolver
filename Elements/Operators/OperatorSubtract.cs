using MatchesRiddleSolver.Elements.Digits;
using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Operators;

// Operator - can be transformed to a + by receiving one matchstick.
internal class OperatorSubtract : ElementBase<string>, ISingleMatchReceiver<string>
{
    public override string GetValue()
    {
        return "-";
    }

    public List<ElementBase<string>> Receive()
    {
        return new List<ElementBase<string>> { new OperatorAdd() };
    }
}