using System.Collections.Generic;

namespace OrderBuddy.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public string Price { get; }
    public string Date { get; }
    public int Id { get; }
    public int VendorId { get; set; }
    private static int _totalCount = 0;
    private static List<Order> _instances = new List<Order> { };

    public Order(string titleParameter, string descriptionParameter, string priceParameter, string dateParameter)
    {
      Title = titleParameter;
      Description = descriptionParameter;
      Price = priceParameter;
      Date = dateParameter;
      _instances.Add(this);
      Id = ++_totalCount;
    }

    public static void EmptyInstancesList()
    {
      _totalCount = 0;
      _instances.Clear();
    }

    public static List<Order> GetInstancesList()
    {
      return _instances;
    }

    public static Order? Find(int id)
    {
      foreach (Order obj in _instances)
      {
        if (obj.Id == id)
        {
          return obj;
        }
      }
      return null;
    }

  }
}
