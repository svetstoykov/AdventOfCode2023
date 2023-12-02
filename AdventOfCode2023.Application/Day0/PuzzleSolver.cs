using AdventOfCode2023.Application.Day0.Interfaces;

namespace AdventOfCode2023.Application.Day0;

public abstract class PuzzleSolver : IPuzzleSolver
{
    protected PuzzleSolver()
    {
        Input = GetInputAsString();
    }

    private const string InputContentFolderName = "Input";

    public abstract int Day { get; }

    public abstract int Part { get; }

    public string Input { get; }

    public abstract void Solve();

    private string GetInputAsString()
    {
        var directory = Directory.GetCurrentDirectory();

        var dailyFolderName = GetDailyFolderName();
        
        var fileName = GetInputFileName();

        var pathToInputFile = Path.Combine(
            directory, dailyFolderName, InputContentFolderName, fileName);

        return File.ReadAllText(pathToInputFile);
    }

    private string GetInputFileName() => $"Part{Part}.txt";
    
    private string GetDailyFolderName() => $"Day{Day}";

    public override string ToString() 
        => $"Day{Day}_Part{Part}";
}