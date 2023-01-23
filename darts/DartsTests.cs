using Xunit;

public class DartsTests
{
    [Fact]
    public void Three_Throws()
    {
        int[,] arrays = { { 5, 2 }, { 2,3 }, { 1, 1 } };
        int[] points = { 1, 5, 5 };

        Assert.Equal(points, Darts.Score(arrays));
    }
}