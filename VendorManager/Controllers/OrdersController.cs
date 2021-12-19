using Microsoft.AspNetCore.Mvc;
using VendorManager.Models;
using System.Collections.Generic;
using System;

namespace VendorManger.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order currentOrder = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", currentVendor);
      model.Add("order", currentOrder);
      return View(model);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}/edit")]
    public ActionResult Edit(int vendorId, int orderId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order currentOrder = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", currentVendor);
      model.Add("order", currentOrder);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Update(string title, string description, DateTime deliveryTime, int vendorId, int orderId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      Order currentOrder = Order.Find(orderId);
      currentOrder.Title = title;
      currentOrder.Description = description;
      currentOrder.DeliveryTime = deliveryTime;
      Dictionary<string, object> model = new Dictionary<string, object>();
      return LocalRedirect($"/vendors/{vendorId}/orders/{orderId}");
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      return View(currentVendor);
    }
  }
}