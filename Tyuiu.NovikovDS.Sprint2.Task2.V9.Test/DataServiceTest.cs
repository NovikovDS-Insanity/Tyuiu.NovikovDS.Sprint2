using Tyuiu.NovikovDS.Sprint2.Task2.V9.Lib;

namespace Tyuiu.NovikovDS.Sprint2.Task2.V9.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int a = 12, b = 11;
        bool res;
        res = ds.CheckDotInShadedArea(a, b);

        Assert.AreEqual(true, res);
    }
}
