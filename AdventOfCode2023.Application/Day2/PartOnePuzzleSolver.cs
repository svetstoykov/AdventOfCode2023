using AdventOfCode2023.Application.Day0;

namespace AdventOfCode2023.Application.Day2;

public class PartOnePuzzleSolver : PuzzleSolver
{
    public override int Day => 2;

    public override int Part => 1;

    public override void Solve()
    {
        var lines = Input.Split("\r\n");

        var maxAllowedPerColor = new Dictionary<string, int>
        {
            {"red", 12}, {"green", 13}, {"blue", 14}
        };

        var result = 0;

        foreach (var game in lines)
        {
            var gameSplit = game.Split(":");
            
            var gameId = int.Parse(string.Join("", gameSplit.First().Skip(5)));
            
            var isPossible = true;

            foreach (var subset in game.Split(":").Last().Split(";"))
            {
                var cubesInSubset = Common.GetCubesInSubset(subset);

                foreach (var cube in cubesInSubset)
                {
                    var countForColor = Common.GetCubeCountForColor(cube);

                    if (maxAllowedPerColor[countForColor.Item2] < countForColor.Item1)
                    {
                        isPossible = false;
                    }
                }
            }

            if (isPossible)
            {
                result += gameId;
            }
        }

        Console.WriteLine(result);
    }
}