using MatchesRiddleSolver.Elements.Digits;
using MatchesRiddleSolver.Elements.ElementsTypes;
using System.Data;

namespace MatchesRiddleSolver.Algorithm;
internal class Algorithm
{
    public static bool Calculate(List<ElementBase<string>> elements)
    {
        string leftExpression = "";
        string rightExpression = "";
        int i = 0;
        for (; i < elements.Count; i++)
        {
            if (elements[i].GetValue().Equals("="))
                break;

            leftExpression += elements[i].GetValue();
        }

        i++;
        for (; i < elements.Count; i++)
        {
            rightExpression += elements[i].GetValue();
        }

        DataTable dt = new DataTable();
        var leftExpressionResult = dt.Compute(leftExpression, "");
        var rightExpressionResult = dt.Compute(rightExpression, "");

        Console.WriteLine($"[{leftExpressionResult.Equals(rightExpressionResult)}] -> {leftExpression} = {rightExpression} => {leftExpressionResult} = {rightExpressionResult}");

        return leftExpressionResult.Equals(rightExpressionResult);
    }

    public static void TrySelfExchangeElements(List<ElementBase<string>> elements)
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if (elements[i] is ISingleMatchSelfExchange<string> exchanger)
            {
                var originalElement = elements[i];
                var exchangedElements = exchanger.Exchange();
                foreach (var exchangedElement in exchangedElements)
                {
                    elements[i] = exchangedElement;
                    Calculate(elements);
                }

                elements[i] = originalElement;
            }
        }
    }

    public static void TryConditionalGiveAndReceiveElements(List<ElementBase<string>> elements)
    {
        for (int giverIndex = 0; giverIndex < elements.Count; giverIndex++)
        {
            if (elements[giverIndex] is ISingleMatchConditionalGiver<string> conditionalGiver)
            {
                var originalGiverElement = elements[giverIndex];

                for (int receiverIndex = 0; receiverIndex < elements.Count; receiverIndex++)
                {
                    if (giverIndex == receiverIndex) // This is covered in TrySelfExchangeElements
                        continue;

                    if (elements[receiverIndex] is ISingleMatchReceiver<string> receiver)
                    {
                        var originalReceiverElement = elements[receiverIndex];

                        var possibleElementsPairs = conditionalGiver.Give(originalReceiverElement);

                        foreach (var possibleElementsPair in possibleElementsPairs)
                        {
                            elements[giverIndex] = possibleElementsPair.Item1;
                            elements[receiverIndex] = possibleElementsPair.Item2;
                            Calculate(elements);
                            elements[receiverIndex] = originalReceiverElement;
                            elements[giverIndex] = originalGiverElement;
                        }
                    }
                }
            }
        }
    }

    public static void TryGiveAndReceiveElements(List<ElementBase<string>> elements)
    {
        // The following iteration is a Log(n)*Log(n)
        for (int giverIndex = 0; giverIndex < elements.Count; giverIndex++)
        {
            if (elements[giverIndex] is ISingleMatchGiver<string> giver)
            {
                var originalGiverElement = elements[giverIndex];
                var giverElements = giver.Give();

                for (int receiverIndex = 0; receiverIndex < elements.Count; receiverIndex++)
                {
                    if (giverIndex == receiverIndex) // This is covered in TrySelfExchangeElements
                        continue;

                    if (elements[receiverIndex] is ISingleMatchReceiver<string> receiver)
                    {
                        var originalReceiverElement = elements[receiverIndex];
                        var receiverElements = receiver.Receive();
                        foreach (var giverElement in giverElements)
                        {
                            elements[giverIndex] = giverElement;
                            foreach (var receiverElement in receiverElements)
                            {
                                elements[receiverIndex] = receiverElement;
                                Calculate(elements);
                                elements[receiverIndex] = originalReceiverElement;
                            }
                            elements[giverIndex] = originalGiverElement;
                        }

                    }
                }
            }
        }
    }
}
