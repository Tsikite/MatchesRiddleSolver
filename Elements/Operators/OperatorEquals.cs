using MatchesRiddleSolver.Elements.Digits;
using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Operators;

internal class OperatorEquals : ElementBase<string>, ISingleMatchConditionalGiver<string>
{
    public override string GetValue()
    {
        return "=";
    }

    public List<(ElementBase<string>, ElementBase<string>)> Give(ElementBase<string> receiver)
    {
        if(receiver.GetType() == typeof(OperatorSubtract))
        {
            return new List<(ElementBase<string>, ElementBase<string>)>
            {
                (new OperatorSubtract(), new OperatorEquals())
            };
        }

        return new List<(ElementBase<string>, ElementBase<string>)>();
    }
}