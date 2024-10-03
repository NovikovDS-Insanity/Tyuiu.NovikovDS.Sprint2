using Tyuiu.NovikovDS.Sprint2.Task7.V8.Lib;

namespace Tyuiu.NovikovDS.Sprint2.Task7.V8.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        double x = 2, y = -0.2;

        Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
    }
}
