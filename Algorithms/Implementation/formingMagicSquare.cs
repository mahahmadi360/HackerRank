namespace TestProject1.Tests;

public class formingMagicSquareTest
{
    [Fact]
    public void Test1()
    {
        var g = FormingMagicSquare.formingMagicSquare(new List<List<int>> { new List<int>{5, 3 ,4 },
                new List<int>{ 1, 5, 8 },
                new List<int>{   6, 4 ,2}});
        Assert.Equal(7, g);
    }

    [Fact]
    public void Test12()
    {
        var g = FormingMagicSquare.formingMagicSquare(new List<List<int>>
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
        var g = FormingMagicSquare.formingMagicSquare(new List<List<int>>{
            new List<int>{6,7,2},
            new List<int>{1,5,9},
            new List<int>{8,3,4}
        });

        Assert.Equal(0, g);
    }
}