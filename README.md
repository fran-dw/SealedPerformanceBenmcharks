# Sealed Performance Benmcharks In NET7
Performance benchamrks for sealed vs open classes

# Sample Result
Sample result from one of the runs.

|        Method |      Mean |     Error |    StdDev |    Median | Allocated |
|-------------- |----------:|----------:|----------:|----------:|----------:|
|      OpenVoid | 0.5538 ns | 0.0708 ns | 0.1853 ns | 0.5049 ns |         - |
|    SealedVoid | 0.0078 ns | 0.0222 ns | 0.0185 ns | 0.0000 ns |         - |
|       OpenInt | 1.7403 ns | 0.1025 ns | 0.3022 ns | 1.6595 ns |         - |
|     SealedInt | 0.0434 ns | 0.0329 ns | 0.0801 ns | 0.0000 ns |         - |
|   IsCheckOpen | 4.5383 ns | 0.2805 ns | 0.8271 ns | 4.7935 ns |         - |
| IsCheckSealed | 0.7279 ns | 0.0853 ns | 0.2446 ns | 0.7001 ns |         - |
|     StoreOpen | 6.7477 ns | 0.2874 ns | 0.8247 ns | 6.5777 ns |         - |
|   StoreSealed | 4.6622 ns | 0.2726 ns | 0.8037 ns | 4.3668 ns |         - |
