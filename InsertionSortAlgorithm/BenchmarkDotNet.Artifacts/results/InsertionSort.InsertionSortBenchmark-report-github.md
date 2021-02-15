``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1316 (1909/November2018Update/19H2)
Intel Core i5-3330 CPU 3.00GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT
  DefaultJob : .NET Core 5.0.2 (CoreCLR 5.0.220.61120, CoreFX 5.0.220.61120), X64 RyuJIT


```
|       Method |          Mean |        Error |       StdDev | Rank | Gen 0 | Gen 1 | Gen 2 |  Allocated |
|------------- |--------------:|-------------:|-------------:|-----:|------:|------:|------:|-----------:|
| SortWithTenT |      58.33 ms |     1.150 ms |     1.230 ms |    1 |     - |     - |     - |    39.4 KB |
| SortWithHunT |   5,544.68 ms |    45.478 ms |    37.976 ms |    2 |     - |     - |     - |  390.95 KB |
| SortWithOneM | 552,103.83 ms | 1,458.987 ms | 1,293.354 ms |    3 |     - |     - |     - | 3908.16 KB |
