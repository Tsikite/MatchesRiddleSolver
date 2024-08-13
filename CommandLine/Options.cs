using CommandLine;

namespace MatchesRiddleSolver.CommandLine
{
    internal class Options
    {
        [Option('r', "riddle", Required = true, HelpText = "The riddle to solve.")]
        public string Riddle { get; set; }

        // Create 2 new dependent mutually exclusive options. only one of 'r' and 'f' can be set.
        [Option('f', "find", Default = false, HelpText = "Find riddles.", Group = "Action")]
        public bool FindRiddles { get; set; }

        [Option('s', "solve", Default = true, HelpText = "Solve the riddle.", Group = "Action")]
        public bool SolveRiddle { get; set; }

        [Option('v', "verbose", Default = false, HelpText = "Prints all the steps of the solution.")]
        public bool Verbose { get; set; }

        [Option('z', "zero-at-start", Default = false, HelpText = "Supports zero at the start of the number.")]
        public bool ZeroAtStartSupported { get; set; }

        [Option('t', "timeout", Default = 5, HelpText = "Timeout in seconds.")]
        public int Timeout { get; set; }
    }
}
