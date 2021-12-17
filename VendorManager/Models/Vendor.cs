using System.Collections.Generic;

namespace VendorManager.Models
{
  public class Vendor
  {
    //Static properties and methods
    private List<Vendor> _instances = new List<Vendor>() { };

    public static List<Vendor> GetAll()
    {
      //TODO
    }

    public static void ClearAll()
    {
      //TODO
    }

    public static Vendor Find(int id)
    {
      //TODO
    }

    //Instance properties and methods
    public int Id { get; }
    public Contact Contact { get; set; }
    public string name { get; set; }

    public Vendor(string name, Contact contact)
    {
      //TODO
    }

    public void AddOrder(Order order)
    {
      //TODO
    }
  }
}