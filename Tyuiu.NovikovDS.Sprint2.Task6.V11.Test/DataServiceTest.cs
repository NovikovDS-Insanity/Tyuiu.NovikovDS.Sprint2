using Tyuiu.NovikovDS.Sprint2.Task6.V11.Lib;

namespace Tyuiu.NovikovDS.Sprint2.Task6.V11.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int g = 2023, m = 12, n = 31;

        Assert.AreEqual("01.01.2024", ds.FindDateOfNextDay(g, m, n));
    }
}
