using Tyuiu.NovikovDS.Sprint2.Task5.V14.Lib;

namespace Tyuiu.NovikovDS.Sprint2.Task5.V14.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 3, y = 91;

        Assert.AreEqual("Вторник", ds.FindDayName(x, y));
    }
}
