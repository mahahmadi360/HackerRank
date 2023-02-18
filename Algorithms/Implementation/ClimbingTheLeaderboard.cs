namespace Algorithms;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var g = climbingLeaderboard(new List<int> { 100, 100, 50, 40, 40, 20, 10 },
            new List<int> { 5, 25, 50, 120 });

        Assert.Equal("6,4,2,1", string.Join(",", g));
    }

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        var result = new List<int>();
        /*var rank = 1;
        var j = 0;
        for (var i = player.Count - 1; i >= 0; i--)
        {
            for (j =j ; j < ranked.Count; j++)
            {
                if (ranked[j] <= player[i])
                    break;

                if (j == 0 ||
                     ranked[j - 1] != ranked[j])
                    rank++;
            }
            result.Insert(0, rank);
        }*/
        //ranked.Add(0);

        //var rankCount = ranked.Count;
        //var rankIndex = 0;
        //var rank = 1;
        //var scoreIndex = player.Count - 1;
        //while (rankIndex < rankCount)
        //{
        //    if (player[scoreIndex] >= ranked[rankIndex])
        //    {
        //        result.Insert(0, rank);
        //        scoreIndex--;

        //        if (scoreIndex == -1)
        //            break;
        //        continue;
        //    }

        //    if (rankIndex == 0 ||
        //        ranked[rankIndex] != ranked[rankIndex - 1])
        //        rank++;

        //    rankIndex++;
        //}

        ranked.Add(0);

        var rankCount = ranked.Count;
        var rankIndex = 0;
        var rank = 1;
        var scoreIndex = player.Count - 1;
        while (rankIndex < rankCount)
        {
            if (rankIndex != 0 &&
                ranked[rankIndex] == ranked[rankIndex - 1])
            {
                rankIndex++;
                continue;
            }

            if (player[scoreIndex] >= ranked[rankIndex])
            {
                result.Insert(0, rank);
                scoreIndex--;

                if (scoreIndex == -1)
                    break;
                continue;
            }

            rankIndex++;
            rank++;
        }
        return result;
    }
}
