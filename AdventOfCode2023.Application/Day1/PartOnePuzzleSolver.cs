using System.Text.RegularExpressions;
using AdventOfCode2023.Application.Day0;

namespace AdventOfCode2023.Application.Day1;

public partial class PartOnePuzzleSolver : PuzzleSolver
{
    public override int Day => 1;

    public override int Part => 1;

    public override void Solve()
    {
        var lines = Input.Split("\n");

        var total = lines.Select(line => NumberExpression()
                .Matches(line)
                .Select(m => m.Value)
                .ToList())
            .Select(nums => int.Parse(
                string.Concat(nums[0], nums[^1])))
            .Sum();
    }

    [GeneratedRegex("[0-9]")]
    private static partial Regex NumberExpression();
}