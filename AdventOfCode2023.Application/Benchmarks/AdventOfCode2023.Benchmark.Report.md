```

BenchmarkDotNet v0.13.10, Windows 11
.NET SDK 7.0.202
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method              | solver     | Mean     | Error    | StdDev   | Gen0     | Gen1    | Allocated |
|-------------------- |----------- |---------:|---------:|---------:|---------:|--------:|----------:|
| PuzzleSolverExecute | Day1_Part1 | 525.0 μs | 10.46 μs | 15.01 μs | 143.5547 | 28.3203 | 882.67 KB |
| PuzzleSolverExecute | Day1_Part2 | 805.0 μs | 15.56 μs | 23.76 μs |  11.7188 |  1.9531 |  75.38 KB |
| PuzzleSolverExecute | Day2_Part1 | 271.7 μs |  5.40 μs | 10.67 μs |  55.6641 |  4.3945 | 341.63 KB |
| PuzzleSolverExecute | Day2_Part2 | 283.9 μs |  5.66 μs |  9.75 μs |  52.7344 |  4.3945 | 324.17 KB |
