using BenchmarkDotNet.Attributes;
using Task_27;

namespace Task_27_benchmark;

[MemoryDiagnoser]
[RankColumn]
public class MyParserBenchmark
{
    private const string STRING_TO_PARSE_WITH_ERROR = "qwerty21";
    private const string STRING_TO_PARSE = "77";

    private readonly MyParser _myParser = new MyParser();

    [Benchmark]
    public void TryCathchParseTestWithError()
    {
        int result = _myParser.TryCathParse(STRING_TO_PARSE_WITH_ERROR);
    }

    [Benchmark]
    public void TryParseTestWithError()
    {
        int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
    }

    [Benchmark]
    public void TryCathchParseTest()
    {
        int result = _myParser.TryCathParse(STRING_TO_PARSE);
    }

    [Benchmark]
    public void TryParseTest()
    {
        int result = _myParser.TryParse(STRING_TO_PARSE);
    }
}


/*
 * Benchmark

|                      Method |         Mean |      Error |    StdDev | Rank |  Gen 0 | Allocated |
|---------------------------- |-------------:|-----------:|----------:|-----:|-------:|----------:|
| TryCathchParseTestWithError | 6,310.980 ns | 11.8058 ns | 9.8584 ns |    4 | 0.0381 |     320 B |
|       TryParseTestWithError |     8.859 ns |  0.0820 ns | 0.0727 ns |    1 |      - |         - |
|          TryCathchParseTest |    11.322 ns |  0.2405 ns | 0.2250 ns |    3 |      - |         - |
|                TryParseTest |    10.420 ns |  0.2357 ns | 0.2315 ns |    2 |      - |         - |

 */
