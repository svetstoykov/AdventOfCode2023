using AdventOfCode2023.Benchmark;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<PuzzleSolverBenchmark>();
