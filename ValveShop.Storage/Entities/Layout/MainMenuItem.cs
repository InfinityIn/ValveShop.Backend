namespace ValveShop.Storage.Entities.Layout;
public class MainMenuItem
{
  public MainMenuItem(int id, string name)
  {
    Id = id; 
    Name = name;
  }
  public int Id { get; set; }
  public string Name { get; set; }
}
