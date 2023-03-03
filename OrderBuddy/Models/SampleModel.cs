using System.Collections.Generic;

namespace OrderBuddy.Models
{
  public class Vendor
  {
    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> { };
    private static int TotalCount = 0;

    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = ++TotalCount;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
