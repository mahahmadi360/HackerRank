namespace TestProject1;

public class formingMagicSquareTest
{
    [Fact]
    public void Test1()
    {
        var g = formingMagicSquare(new List<List<int>> { new List<int>{5, 3 ,4 },
                new List<int>{ 1, 5, 8 },
                new List<int>{   6, 4 ,2}});
        Assert.Equal(7, g);
    }

    [Fact]
    public void Test12()
    {
        var g = formingMagicSquare(new List<List<int>>
        {
            new List<int>{4 ,9 ,2 },
            new List<int>{3 ,5 ,7},
            new List<int>{8 ,1 ,5}
        });

        Assert.Equal(1, g);
    }

    [Fact]
    public void Test13()
    {
        var g = formingMagicSquare(new List<List<int>>{
            new List<int>{6,7,2},
            new List<int>{1,5,9},
            new List<int>{8,3,4}
        });

        Assert.Equal(0, g);
    }

    public int formingMagicSquare(List<List<int>> s)
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

    private List<List<int>> Rotate(List<List<int>> s)
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

    private List<List<int>> Flip(List<List<int>> s)
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

    private int GetCost(List<List<int>> s)
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
