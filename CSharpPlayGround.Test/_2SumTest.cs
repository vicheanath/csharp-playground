namespace CSharpPlayGround.Test;

public class _2SumTest
{
    [Fact]
    public void Case1()
    {
        var _2Sum = new _2Sum();
        var result = _2Sum.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void Case2()
    {
        var _2Sum = new _2Sum();
        var result = _2Sum.TwoSum(new int[] { 3, 2, 4 }, 6);
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void Case3()
    {
        var _2Sum = new _2Sum();
        var result = _2Sum.TwoSum(new int[] { 3, 3 }, 6);
        Assert.Equal(new int[] { 0, 1 }, result);
    }
    [Fact]
    public void Case4()
    {
        var _2Sum = new _2Sum();
        var result = _2Sum.TwoSum(new int[] { 3, 2, 3 }, 6);
        Assert.Equal(new int[] { 0, 2 }, result);
    }
}
