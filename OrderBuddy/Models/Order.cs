namespace OrderBuddy.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public string Price { get; }
    public string Date { get; }

    public Order(string titleParameter)
    {
      Title = titleParameter;
    }
  }
}
