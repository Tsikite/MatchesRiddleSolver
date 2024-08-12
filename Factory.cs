using MatchesRiddleSolver.Elements.Digits;
using MatchesRiddleSolver.Elements.Operators;

namespace MatchesRiddleSolver;

internal class Factory
{
    private static readonly Dictionary<char, Func<ElementBase<string>>> _digitFactory = new()
    {
        { '0', () => new Digit00() },
        { '1', () => new Digit01() },
        { '2', () => new Digit02() },
        { '3', () => new Digit03() },
        { '4', () => new Digit04() },
        { '5', () => new Digit05() },
        { '6', () => new Digit06() },
        { '7', () => new Digit07() },
        { '8', () => new Digit08() },
        { '9', () => new Digit09() }
    };

    public static List<ElementBase<string>> FromString(string math)
    {
        var elements = new List<ElementBase<string>>();
        
        var mathArray = math.ToCharArray();
        
        if(char.IsDigit(mathArray[0]))
            elements.Add(new OperatorAddHidden());

        foreach (var t in mathArray)
        {
            if (char.IsDigit(t))
            {
                elements.Add(_digitFactory[t]());
            }
            else
            {
                switch (t)
                {
                    case '+':
                        elements.Add(new OperatorAdd());
                        break;
                    case '-':
                        elements.Add(new OperatorSubtract());
                        break;
                    case '*':
                        elements.Add(new OperatorMultiply());
                        break;
                    case '=':
                        elements.Add(new OperatorEquals());
                        break;
                    default:
                        throw new ArgumentException($"Invalid character in math string '{t}'");
                }
            }
        }
        return elements;
    }
}