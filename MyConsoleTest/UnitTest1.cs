namespace MyConsoleTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void Helper_Add_AlwaysPass()
    {
        Assert.Pass();
    }
    [Test]
    public void Helper_Add_10_20_Return10()
    {
        Assert.AreEqual(Helper.Add(10, 20), 10);
    }
    [Test]
    public void Helper_Add_10_20_Return30()
    {
        Assert.AreEqual(Helper.Add(10, 20), 30);
    }
}