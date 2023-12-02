using AdventOfCode2023.Application.Day0;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2023.Benchmark;

[MemoryDiagnoser]
public class PuzzleSolverBenchmark
{
    [Benchmark]
    [ArgumentsSource(nameof(Solvers))]
    public void PuzzleSolverExecute(PuzzleSolver solver)
    {
        solver.Solve();
    }

    public static IEnumerable<PuzzleSolver> Solvers()
    {
        var assembly = typeof(PuzzleSolver).Assembly;

        var puzzleSolverTypes = assembly.GetTypes()
            .Where(type => type.IsSubclassOf(typeof(PuzzleSolver)));

        return puzzleSolverTypes
            .Select(solverType => 
                Activator.CreateInstance(solverType) as PuzzleSolver)
            .ToList()!;
    }
}