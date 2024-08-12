
using MatchesRiddleSolver.Elements.Digits;
using MatchesRiddleSolver.Elements.ElementsTypes;

namespace MatchesRiddleSolver.Elements.Operators
{
    internal class OperatorAddHidden : ElementBase<string>, ISingleMatchReceiver<string>
    {
        public override string GetValue()
        {
            return "";
        }

        public List<ElementBase<string>> Receive()
        {
            return new List<ElementBase<string>> { new OperatorSubtract() };
        }
    }
}
