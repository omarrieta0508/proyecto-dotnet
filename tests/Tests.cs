using Xunit;

public class Tests
{
    [Fact]
    public void Test_Suma()
    {
        int a = 2;
        int b = 3;
        Assert.Equal(5, a+b);
    }
}