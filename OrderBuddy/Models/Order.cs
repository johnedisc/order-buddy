using System.Collections.Generic;

namespace OrderBuddy.Models
{
  public class Order
  {
    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> { };
    private static int TotalCount = 0;

  }
}
