``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.804 (2004/?/20H1)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  DefaultJob : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT


```
|                    Method |       Mean |      Error |     StdDev |     Median | Rank |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |-----------:|-----------:|-----------:|-----------:|-----:|---------:|------:|------:|----------:|
|  QuickSortWithHundredData |   6.104 μs |  0.2703 μs |  0.7625 μs |   5.860 μs |    1 |        - |     - |     - |         - |
|  MergeSortWithHundredData |  10.395 μs |  0.5380 μs |  1.5864 μs |  10.010 μs |    2 |  13.7939 |     - |     - |   21648 B |
| MergeSortWith5HundredData |  80.298 μs |  3.3278 μs |  9.8122 μs |  79.077 μs |    3 |  76.7822 |     - |     - |  120432 B |
| QuickSortWith5HundredData | 136.544 μs |  4.2718 μs | 12.3933 μs | 134.496 μs |    4 |        - |     - |     - |         - |
| MergeSortWithThousandData | 166.486 μs |  4.5801 μs | 13.3604 μs | 165.830 μs |    5 | 161.1328 |     - |     - |  252960 B |
| QuickSortWithThousandData | 490.958 μs | 12.8048 μs | 37.3523 μs | 483.955 μs |    6 |        - |     - |     - |         - |
