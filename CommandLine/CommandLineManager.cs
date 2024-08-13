

using CommandLine;
using CommandLine.Text;
using System.Reflection;

namespace MatchesRiddleSolver.CommandLine;

internal static class CommandLineManager
{
    public static void ParseCommandLine(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithNotParsed(errors =>
            {
                foreach (var error in errors)
                {
                    if (error is VersionRequestedError)
                    {
                        // Get version number
                        Console.WriteLine($"Version: {Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown"}");
                    }
                }
            })
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

