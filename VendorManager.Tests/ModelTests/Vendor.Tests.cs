using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorManager.Models;
using System.Collections.Generic;
using System;

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
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new(testName, testContact);
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Vendor testVendor = new(testName, testContact);
      Assert.AreEqual(testName, testVendor.Name);
    }

    [TestMethod]
    public void GetContact_ReturnsContact_Contact()
    {
      Vendor testVendor = new(testName, testContact);
      Assert.AreEqual(testContact, testVendor.Contact);
    }

    [TestMethod]
    public void GetId_ReturnsId_int()
    {
      Vendor testVendor01 = new(testName, testContact);
      Vendor testVendor02 = new(testName, testContact);
      Assert.AreEqual(1, testVendor01.Id);
      Assert.AreEqual(2, testVendor02.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsFullInstanceList_List()
    {
      Vendor testVendor01 = new(testName, testContact);
      Vendor testVendor02 = new(testName, testContact);
      List<Vendor> expectedList = new List<Vendor>() { testVendor01, testVendor02 };
      CollectionAssert.AreEqual(expectedList, Vendor.GetAll());
    }

    [TestMethod]
    public void ClearAll_ClearsInstanceList_EmptyList()
    {
      Vendor testVendor01 = new(testName, testContact);
      Vendor testVendor02 = new(testName, testContact);
      List<Vendor> expectedList = new List<Vendor>() { };
      Vendor.ClearAll();
      CollectionAssert.AreEqual(expectedList, Vendor.GetAll());
    }

    [TestMethod]
    public void Find_FindsCorrectInstance_Vendor()
    {
      Vendor testVendor01 = new(testName, testContact);
      Vendor testVendor02 = new(testName, testContact);
      Assert.AreEqual(testVendor02, Vendor.Find(testVendor02.Id));
    }

    [TestMethod]
    public void AddOrder_OrderAddedToList_OrderList()
    {
      Vendor testVendor = new(testName, testContact);
      Order testOrder = new("testTitle", "testDescription", new DateTime());
      testVendor.AddOrder(testOrder);
      List<Order> expectedList = new List<Order>() { testOrder };
      CollectionAssert.AreEqual(expectedList, testVendor.Orders);
    }
  }
}