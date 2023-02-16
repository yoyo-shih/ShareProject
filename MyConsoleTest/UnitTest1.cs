namespace MyConsoleTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        // 初始化可以在這邊設定
    }
    [Test]
    public void NUnit_Introduce_Assert()
    {
        Assert.Pass();

        Assert.Fail();

        Assert.AreEqual("string", "string");

        Assert.AreEqual(1, 1);

        Assert.AreNotEqual(1, 10);

        Assert.IsTrue(true);

        Assert.IsFalse(false);

        Assert.Throws<ArgumentException>(() => new ArgumentException("this is a exception!"));

        Assert.DoesNotThrow(() => { Console.WriteLine("OK"); });
    }

    [Test]
    [TestCase(10, 20, 30)]
    [TestCase(20, 20, 40)]
    [TestCase(30, 40, 50)]
    public void Helper_Add_TestCase(int a, int b, int ans)
    {
        Assert.AreEqual(Helper.Add(a, b), ans);
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