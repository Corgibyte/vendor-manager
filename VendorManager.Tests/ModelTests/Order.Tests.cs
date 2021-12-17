using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorManager.Models;
using System.Collections.Generic;
using System;

namespace VendorManager.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    private static string testTitle = "Test title";
    private static string testDescription = "Test description";
    private static DateTime testDeliveryDate = new(2022, 10, 3, 14, 00, 00);

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(typeof(Vendor), testOrder.GetType());
      //! TODO : must change back to typeof(Order) to make test pass 
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      Order testOrder = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(testTitle, testOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Order testOrder = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(testDescription, testOrder.Description);
    }

    [TestMethod]
    public void GetId_ReturnsId_int()
    {
      Order testOrder01 = new(testTitle, testDescription, testDeliveryDate);
      Order testOrder02 = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(1, testOrder01.Id);
      Assert.AreEqual(2, testOrder02.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsFullInstanceList_List()
    {
      Order testOrder01 = new(testTitle, testDescription, testDeliveryDate);
      Order testOrder02 = new(testTitle, testDescription, testDeliveryDate);
      List<Order> expectedList = new List<Order>() { testOrder01, testOrder02 };
      CollectionAssert.AreEqual(expectedList, Order.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsInstanceList_EmptyList()
    {
      Order testOrder01 = new(testTitle, testDescription, testDeliveryDate);
      Order testOrder02 = new(testTitle, testDescription, testDeliveryDate);
      List<Order> expectedList = new List<Order>() { };
      Order.ClearAll();
      CollectionAssert.AreEqual(expectedList, Order.GetAll());
    }

    [TestMethod]
    public void Find_FindsCorrectInstance_Order()
    {
      Order testOrder01 = new(testTitle, testDescription, testDeliveryDate);
      Order testOrder02 = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(testOrder02, Order.Find(testOrder02.Id));
    }

    [TestMethod]
    public void GetDeliveryTime_ReturnsDeliveryTime_DateTime()
    {
      Order testOrder = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(testDeliveryDate, testOrder.DeliveryTime);
    }

    [TestMethod]
    public void GetCreatedTime_ReturnsCreatedTime_DateTime()
    {
      Order testOrder = new(testTitle, testDescription, testDeliveryDate);
      Assert.AreEqual(DateTime.Now, testOrder.TimeCreated);
    }
  }
}