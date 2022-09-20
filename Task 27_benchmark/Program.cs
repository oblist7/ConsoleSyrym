
using BenchmarkDotNet.Running;

namespace Task_27_benchmark;

class Program
{
    static void Main()
    {
        BenchmarkRunner.Run<MyParserBenchmark>();
    }
}
