using System;
using System.Collections.Generic;

namespace VendorManager.Models
{
  public class Order
  {

    //Static properties and methods
    private static List<Order> _instances = new List<Order>() { };

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int id)
    {
      return _instances[id - 1];
    }

    //Instance properties and methods
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime TimeCreated { get; }
    public DateTime DeliveryTime { get; set; }

    public Order(string title, string description, DateTime deliveryTime)
    {
      Title = title;
      Description = description;
      DeliveryTime = deliveryTime;
      TimeCreated = DateTime.Now;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}