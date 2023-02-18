namespace TestProject1;

public static class FormingMagicSquare
{
    public static int formingMagicSquare(List<List<int>> s)
    {
        int cost = int.MaxValue;
        for (int i = 0; i < 4; i++)
        {
            var rotatedCost = GetCost(s);
            if (rotatedCost < cost)
                cost = rotatedCost;

            s = Flip(s);
            rotatedCost = GetCost(s);
            if (rotatedCost < cost)
                cost = rotatedCost;

            if (i == 3)
                break;
            s = Rotate(s);
        }
        return cost;
    }

    private static List<List<int>> Rotate(List<List<int>> s)
    {
        var rotated = new List<List<int>>();
        for (int i = 0; i < 3; i++)
        {
            var row = new List<int>{
                s[2][i],
                s[1][i],
                s[0][i]
            };
            rotated.Add(row);
        }
        return rotated;
    }

    private static List<List<int>> Flip(List<List<int>> s)
    {
        var rotated = new List<List<int>>();
        for (int i = 0; i < 3; i++)
        {
            var row = new List<int>{
                s[2][i],
                s[1][i],
                s[0][i]
            };
            rotated.Add(row);
        }
        return rotated;
    }

    private static int GetCost(List<List<int>> s)
    {
        var magicSquare = new int[3, 3]{
            {8,3,4},{1,5,9},{6,7,2}
        };
        var cost = 0;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                cost += Math.Abs(s[i][j] - magicSquare[i, j]);

        return cost;
    }
}
