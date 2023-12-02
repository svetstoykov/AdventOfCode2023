namespace AdventOfCode2023.Application.Day2;

public static class Common
{
    public static IEnumerable<string> GetCubesInSubset(string subset)
        =>  subset
            .Split(", ")
            .Select(v => v.Trim());

    public static (int, string) GetCubeCountForColor(string cube)
    {
        var values = cube.Split(" ");
        var count = int.Parse(values[0]);
        var color = values[1];
        
        return (count, color);
    }
}