namespace AdventOfCode2023.Application.Day0.Interfaces;

public interface IPuzzleSolver
{
    int Day { get; }
    
    int Part { get; }
    
    string Input { get; }
    
    void Solve();
}