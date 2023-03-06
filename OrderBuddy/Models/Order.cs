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
    private static int _totalCount = 0;

    public Order(string titleParameter, string descriptionParameter, string priceParameter, string dateParameter)
    {
      Title = titleParameter;
      Description = descriptionParameter;
      Price = priceParameter;
      Date = dateParameter;
      Id = ++_totalCount;
    }
  }
}
