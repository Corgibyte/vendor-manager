using System.Collections.Generic;

namespace VendorManager.Models
{
  public class Vendor
  {
    //Static properties and methods
    private static List<Vendor> _instances = new List<Vendor>() { };

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int id)
    {
      return _instances[id - 1];
    }

    //Instance properties and methods
    public int Id { get; }
    public Contact Contact { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; }

    public Vendor(string name, Contact contact)
    {
      Name = name;
      Contact = contact;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>() { };
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}