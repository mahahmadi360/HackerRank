using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmark;

public class ClimbingTheLeaderboardBenchmark
{
    private void CallSenario(Action<List<int>, List<int>> senario)
    {
        senario(new List<int> { 100, 100, 50, 40, 40, 20, 10 },
            new List<int> { 5, 25, 50, 120 });
    }

    [Benchmark]
    public void Senario1()
    {
        CallSenario((a, b) => ClimbingTheLeaderboard.climbingLeaderboard1(a, b));
    }

    [Benchmark]
    public void Senario2()
    {
        CallSenario((a, b) => ClimbingTheLeaderboard.climbingLeaderboard2(a, b));
    }


    [Benchmark]
    public void Senario3()
    {
        CallSenario((a, b) => ClimbingTheLeaderboard.climbingLeaderboard3(a, b));
    }
}
