using Tyuiu.NovikovDS.Sprint2.Task0.V22.Lib;

namespace Tyuiu.NovikovDS.Sprint2.Task0.V22.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 3105, y = 77;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        bool[] wait = new bool[6] { false, true, false, true, false, true };
        CollectionAssert.AreEqual(wait, res);
    }
}
