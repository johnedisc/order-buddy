using System.Collections.Generic;

namespace OrderBuddy.Models
{
  public class Vendor
  {
    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> { };
    private static int _totalCount = 0;

    public Vendor(string Name, string Description)
    {
    }

  }
}
