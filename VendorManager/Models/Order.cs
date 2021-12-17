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
      //TODO
      return new List<Order>() { null };
    }

    public static void ClearAll()
    {
      //TODO
    }

    public static Order Find(int id)
    {
      //TODO
      return new Order("test", "test", new DateTime());
    }

    //Instance properties and methods
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime TimeCreated { get; }
    public DateTime DeliveryTime { get; set; }

    public Order(string title, string description, DateTime deliveryTime)
    {
      //TODO
    }
  }
}