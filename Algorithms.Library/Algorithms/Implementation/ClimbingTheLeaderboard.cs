namespace Algorithms;

public static class ClimbingTheLeaderboard
{
    public static List<int> climbingLeaderboard1(List<int> ranked, List<int> player)
    {
        var result = new List<int>();
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


    public static List<int> climbingLeaderboard2(List<int> ranked, List<int> player)
    {
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
                player[scoreIndex] = rank;
                scoreIndex--;

                if (scoreIndex == -1)
                    break;
                continue;
            }

            rankIndex++;
            rank++;
        }

        return player;
    }

    public static List<int> climbingLeaderboard3(List<int> ranked, List<int> player)
    {
        List<int> _ranked = new List<int>();

        _ranked.Add(ranked[0]);
        for (int a = 1; a < ranked.Count(); a++)
            if (_ranked[_ranked.Count() - 1] != ranked[a])
                _ranked.Add(ranked[a]);

        int j = _ranked.Count() - 1;
        int i = 0;
        while (i < player.Count())
        {
            if (j < 0)
            {
                player[i] = 1;
                i++;
                continue;
            }

            if (player[i] < _ranked[j])
            {
                player[i] = j + 2;
                i++;
            }
            else
            if (player[i] == _ranked[j])
            {
                player[i] = j + 1;
                i++;
            }
            else
            {
                j--;
            }
        }

        return player;
    }
}
