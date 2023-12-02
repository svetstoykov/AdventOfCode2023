using AdventOfCode2023.Benchmark;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<PuzzleSolverBenchmark>();

var logger = ConsoleLogger.Default;
MarkdownExporter.Console.ExportToLog(summary, logger);