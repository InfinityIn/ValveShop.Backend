using System.Collections.Immutable;

namespace ValveShop.Storage.Entities.Layout.Abstract;
public abstract class ProductProperty
{
  public ProductProperty(int _id, string _name, int _priority)
  {
    Id = _id;
    Name = _name;
    Priority = _priority;
  }
  public int Id { get; set; }
  public string Name { get; set; }
  public int Priority { get; set; }
  public int FollowedMenuItem { get; set; }
}