using Microsoft.AspNetCore.Mvc;
using VendorManager.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;

namespace VendorManager.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View(Vendor.GetAll());
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/")]
    public ActionResult Create(IFormCollection formContents)
    {
      string name = formContents["name"];
      string contactName = formContents["contactName"];
      string contactEmail = formContents["contactEmail"];
      string contactPhone = formContents.ContainsKey("contactPhone") ? formContents["contactPhone"] : "Not given";
      string contactPronouns = formContents.ContainsKey("contactPronouns") ? formContents["contactPronouns"] : "Not given";
      Contact newContact = new(contactName, contactEmail, contactPhone, contactPronouns);
      Vendor newVendor = new(name, newContact);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      List<Order> vendorsOrders = Vendor.Find(vendorId).Orders;
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", vendorsOrders);
      model.Add("vendor", Vendor.Find(vendorId));
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/edit")]
    public ActionResult Edit(int vendorId)
    {
      return View();
    }

    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Update(IFormCollection formContents, int vendorId)
    {
      string name = formContents["name"];
      string contactName = formContents["contactName"];
      string contactEmail = formContents["contactEmail"];
      string contactPhone = formContents.ContainsKey("contactPhone") ? formContents["contactPhone"] : "Not given";
      string contactPronouns = formContents.ContainsKey("contactPronouns") ? formContents["contactPronouns"] : "Not given";
      Contact newContact = new(contactName, contactEmail, contactPhone, contactPronouns);
      Vendor updatingVendor = Vendor.Find(vendorId);
      updatingVendor.Name = name;
      updatingVendor.Contact = newContact;
      return RedirectToAction("Show");
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, DateTime deliveryTime)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order newOrder = new(title, description, deliveryTime);
      currentVendor.AddOrder(newOrder);
      List<Order> vendorsOrders = currentVendor.Orders;
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", vendorsOrders);
      model.Add("vendor", currentVendor);
      return LocalRedirect($"/vendors/{vendorId}");
    }
  }
}
