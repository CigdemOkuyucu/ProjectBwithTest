namespace MyUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Console.WriteLine("TestMethod1");   
        
        int actual = Calculate.Add(5,7);
        int expected =24;
        Assert.AreEqual(expected, actual,"Equal?");
        
    }
}