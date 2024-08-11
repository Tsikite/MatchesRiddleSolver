using MatchesRiddleSolver.Elements.Digits;

namespace MatchesRiddleSolver.Elements.ElementsTypes;

internal interface ISingleMatchReceiver<TElementType>
{
    /// <summary>
    /// Returns all elements that can be obtained by adding one matchstick.
    /// </summary>
    /// <returns></returns>
    List<ElementBase<TElementType>> Receive();
}