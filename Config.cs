
namespace MatchesRiddleSolver
{
    // Make Config class internal singleton
    internal class Config
    {
        private static Config _instance;
        private Config() { }
        public static Config Instance
        {
            get { return _instance ??= new Config(); }
        }

        public bool OutputCalculationProgress = false;

        public bool ZeroAtStartSupported = false;

        public char[] SupportedOperators = new char[] { '+', '-', '*', '=' };

        public string Riddle = "";

        public Action? Action = null;

        public TimeSpan Timeout = TimeSpan.FromSeconds(5);
    }
    
}
