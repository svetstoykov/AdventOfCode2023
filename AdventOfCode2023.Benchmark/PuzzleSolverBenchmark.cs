using AdventOfCode2023.Application.Day0.Interfaces;
using AdventOfCode2023.Application.Day1;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2023.Benchmark;

[MemoryDiagnoser]
public class PuzzleSolverBenchmark
{
    private IPuzzleSolver solver;

    [GlobalSetup]
    public void Setup()
    {
        solver = new PartTwoPuzzleSolver();
    }

    [Benchmark]
    public void SolveBenchmark()
    {
        solver.Solve();
    }
}