using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorManager.Models;

namespace VendorManager.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    private static string testName = "Test name";
    private static Contact testContact = new("Test name", "Test email");

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new(testName, testDescription, testContact);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Order testOrder = new(testName, testDescription, testContact);
      Assert.AreEqual(testName, testOrder.Name);
    }

    [TestMethod]
    public void GetContact_ReturnsContact_Contact()
    {
      Order testOrder = new(testName, testDescription, testContact);
      Assert.AreEqual(testContact, testOrder.Contact);
    }

    [TestMethod]
    public void GetId_ReturnsId_int()
    {
      Order testOrder01 = new(testName, testDescription, testContact);
      Order testOrder02 = new(testName, testDescription, testContact);
      Assert.AreEqual(1, testOrder01.Id);
      Assert.AreEqual(2, testOrder02.Id);
    }
  }
}