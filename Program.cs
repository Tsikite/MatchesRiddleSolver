using MatchesRiddleSolver;
using MatchesRiddleSolver.CommandLine;
using MatchesRiddleSolver.Utils;
using Action = MatchesRiddleSolver.Action;

CommandLineManager.ParseCommandLine(args);

CancellationTokenSource cts = new CancellationTokenSource(Config.Instance.Timeout);

async Task SolveRiddleAsync()
{
    var elements = Factory.FromString(Config.Instance.Riddle);

    await Task.Run(() =>
    {
        var solutions = elements.FindSolutions(cts.Token);

        Console.WriteLine($"Found {solutions.Count} solutions.");

        foreach (var solution in solutions)
            Console.WriteLine(solution);
    });
}

async Task FindRiddlesAsync()
{
    await Task.Run(() =>
    {
        var (template, numbers) = Utils.GetStringFormat(Config.Instance.Riddle);

        Console.WriteLine($"Start searching for {Config.Instance.Timeout}");

        var token = cts.Token;
        while (token.IsCancellationRequested == false)
        {
            // Format the template with the numbers
            var input = string.Format(template, numbers.Select(a => (object)a).ToArray());

            var elements = Factory.FromString(input);

            var found = elements.FindSolutions(token);

            if (found.Count > 0)
                Console.WriteLine(input + $" ({found.Count})");

            numbers[^1]++;
        }
    });
}

try
{
    var action = Config.Instance.Action;

    switch (action)
    {
        case Action.SolveRiddle:
            await SolveRiddleAsync();
            break;
        case Action.FindRiddles:
            await FindRiddlesAsync();
            break;
        case null:
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}