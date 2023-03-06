using System.Collections.Generic;

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
  }
}
