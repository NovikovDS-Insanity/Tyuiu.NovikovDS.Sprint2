using Tyuiu.NovikovDS.Sprint2.Task3.V8.Lib;

namespace Tyuiu.NovikovDS.Sprint2.Task3.V8.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        double x = -10, res = ds.Calculate(x);

        Assert.AreEqual(0.744, res);
    }
}
