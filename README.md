# MatchesRiddleSolver

![image](https://github.com/user-attachments/assets/f3cb67ca-b60d-44d7-9a68-22146f8e2832)

Command line arguments:

MatchesRiddleSolver.exe --help

  -r, --riddle           Required. The riddle to solve.

  -f, --find             (Group: Action) (Default: false) Find riddles.

  -s, --solve            (Group: Action) (Default: true) Solve the riddle.

  -v, --verbose          (Default: false) Prints all the steps of the solution.

  -z, --zero-at-start    (Default: false) Supports zero at the start of the number.

  -t, --timeout          (Default: 5) Timeout in seconds.

  --help                 Display this help screen.

  --version              Display version information.

  
Example:

MatchesRiddleSolver.exe -r 10+11+12+13=14

OUTPUT:

Found 1 solutions.
10+11+12-19=14
