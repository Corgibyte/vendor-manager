using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorManager.Models;

namespace VendorManager.Tests
{
  [TestClass]
  public class ContactTests
  {

    [TestMethod]
    public void ContactConstructor_CreatesInstanceOfContact_Contact()
    {
      Contact newContact = new("Test name", "Test email");
      Assert.AreEqual(typeof(Contact), newContact.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string testName = "Test name";
      string testEmail = "Test email";
      Contact newContact = new(testName, testEmail);
      Assert.AreEqual(testName, newContact.Name);
    }

    [TestMethod]
    public void GetEmail_ReturnsEmail_String()
    {
      string testName = "Test name";
      string testEmail = "Test email";
      Contact newContact = new(testName, testEmail);
      Assert.AreEqual(testEmail, newContact.Email);
    }

    [TestMethod]
    public void GetPhone_ReturnsPhone_String()
    {
      string testName = "Test name";
      string testEmail = "Test email";
      Contact newContact = new(testName, testEmail);
      Assert.AreEqual("Not given", newContact.Phone);
    }

    [TestMethod]
    public void GetPronouns_ReturnsPronouns_String()
    {
      string testName = "Test name";
      string testEmail = "Test email";
      Contact newContact = new(testName, testEmail);
      Assert.AreEqual("Not given", newContact.Pronouns);
    }
  }
}