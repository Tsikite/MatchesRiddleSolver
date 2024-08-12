using MatchesRiddleSolver;
using MatchesRiddleSolver.Algorithm;

// Get command line arguments
string[] args1 = Environment.GetCommandLineArgs();

// Check if the user has provided a riddle
if (args1.Length < 2)
{
    Console.WriteLine("Please provide a riddle.");
    return;
}

var elements = Factory.FromString(args1[1]);

Algorithm.Calculate(elements);
Algorithm.TrySelfExchangeElements(elements);
Algorithm.TryGiveAndReceiveElements(elements);
Algorithm.TryConditionalGiveAndReceiveElements(elements);