using MatchesRiddleSolver.Elements.Digits;

namespace MatchesRiddleSolver.Elements.ElementsTypes;

internal interface ISingleMatchSelfExchange<TElementType>
{
    /// <summary>
    /// Returns all elements that can be obtained by self exchanging one matchstick.
    /// </summary>
    /// <returns></returns>
    List<ElementBase<TElementType>> Exchange();
}