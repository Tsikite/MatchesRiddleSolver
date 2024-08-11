using MatchesRiddleSolver.Elements.Digits;

namespace MatchesRiddleSolver.Elements.Operators;

internal class OperatorEquals : ElementBase<string>
{
    public override string GetValue()
    {
        return "=";
    }
}