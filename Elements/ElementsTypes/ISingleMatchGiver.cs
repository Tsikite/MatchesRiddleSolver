using MatchesRiddleSolver.Elements.Digits;

namespace MatchesRiddleSolver.Elements.ElementsTypes;

internal interface ISingleMatchGiver<TElementType>
{
    /// <summary>
    /// Returns all elements that can be obtained by removing one matchstick.
    /// </summary>
    /// <returns></returns>
    List<ElementBase<TElementType>> Give();
}