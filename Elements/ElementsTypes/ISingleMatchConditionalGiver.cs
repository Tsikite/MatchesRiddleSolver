using MatchesRiddleSolver.Elements.Digits;

namespace MatchesRiddleSolver.Elements.ElementsTypes;

internal interface ISingleMatchConditionalGiver<TElementType>
{
    /// <summary>
    /// Returns all transformation pairs that can be obtained by one matchstick move between the giver and the receiver.
    /// </summary>
    /// <returns></returns>
    List<(ElementBase<TElementType>, ElementBase<TElementType>)> Give(ElementBase<TElementType> receiver);
}