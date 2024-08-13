using CommandLine;

namespace MatchesRiddleSolver.CommandLine;

internal static class CommandLineManager
{
    public static void ParseCommandLine(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                Config.Instance.OutputCalculationProgress = options.Verbose;
                Config.Instance.ZeroAtStartSupported = options.ZeroAtStartSupported;
                Config.Instance.Timeout = TimeSpan.FromSeconds(options.Timeout);
                Config.Instance.Riddle = options.Riddle;
                if (options.FindRiddles)
                    Config.Instance.Action = Action.FindRiddles;
                else if (options.SolveRiddle)
                    Config.Instance.Action = Action.SolveRiddle;
            });
    }
}

