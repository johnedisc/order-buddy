using System.Collections.Generic;
using System.Linq;

namespace OrderBuddy.Models
{
  public class Vendor
  {
    public string Description { get; }
    public string Name { get; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; }
    private static List<Vendor> _instances = new List<Vendor>{};
    private static int _totalCount = 0;

    public Vendor(string nameParameter, string desciptionParameter)
    {
      Name = nameParameter;
      Description = desciptionParameter;
      _instances.Add(this);
      Id = ++_totalCount;
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetInstancesList()
    {
      return _instances;
    }

    public static void EmptyInstancesList()
    {
      _totalCount = 0;
      _instances.Clear();
    }

    public static Vendor? Find(int id)
    {
      foreach (Vendor obj in _instances)
      {
        if (obj.Id == id)
        {
          return obj;
        }
      }
      return null;
    }

    public void DeleteOrder(int OrderId)
    {
      foreach (Order element in Orders.ToList())
      {
        if (element.Id == OrderId)
        {
          Orders.Remove(element);
        }
      }
    }


  }
}
