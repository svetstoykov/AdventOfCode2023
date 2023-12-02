using AdventOfCode2023.Application.Day0;

namespace AdventOfCode2023.Application.Day2;

public class PartTwoPuzzleSolver : PuzzleSolver
{
    public override int Day => 2;

    public override int Part => 2;

    public override void Solve()
    {
        var lines = Input.Split("\r\n");

        var result = 0;

        foreach (var game in lines)
        {
            var highestPerColor = new Dictionary<string, int>();

            foreach (var subset in game.Split(":").Last().Split(";"))
            {
                var cubesInSubset = subset
                    .Split(", ")
                    .Select(v => v.Trim());

                foreach (var cube in cubesInSubset)
                {
                    var countForColor = Common.GetCubeCountForColor(cube);

                    highestPerColor.TryAdd(countForColor.Item2, 0);

                    if (highestPerColor[countForColor.Item2] < countForColor.Item1)
                    {
                        highestPerColor[countForColor.Item2] = countForColor.Item1;
                    }
                }
            }

            result += highestPerColor.Values.Aggregate((a, b) => a * b);
        }

        Console.WriteLine(result);
    }
}