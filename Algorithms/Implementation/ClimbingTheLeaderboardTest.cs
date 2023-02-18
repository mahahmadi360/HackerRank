using Algorithms;
namespace Algorithms.Tests;

public class ClimbingTheLeaderboardTest
{
    [Fact]
    public void climbingLeaderboard1()
    {
        var g = ClimbingTheLeaderboard.climbingLeaderboard1(new List<int> { 100, 100, 50, 40, 40, 20, 10 },
            new List<int> { 5, 25, 50, 120 });

        Assert.Equal("6,4,2,1", string.Join(",", g));
    }

    [Fact]
    public void climbingLeaderboard2()
    {
        var g = ClimbingTheLeaderboard.climbingLeaderboard2(new List<int> { 100, 100, 50, 40, 40, 20, 10 },
            new List<int> { 5, 25, 50, 120 });

        Assert.Equal("6,4,2,1", string.Join(",", g));
    }


    [Fact]
    public void climbingLeaderboard3()
    {
        var g = ClimbingTheLeaderboard.climbingLeaderboard3(new List<int> { 100, 100, 50, 40, 40, 20, 10 },
            new List<int> { 5, 25, 50, 120 });

        Assert.Equal("6,4,2,1", string.Join(",", g));
    }

}
