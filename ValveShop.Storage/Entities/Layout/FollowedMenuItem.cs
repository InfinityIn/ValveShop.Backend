namespace ValveShop.Storage.Entities.Layout;

public class FollowedMenuItem
{
  public FollowedMenuItem(int id, string name, int mainMenuItemId)
  {
    Id = id;
    Name = name;
    MainMenuItemId = mainMenuItemId;
  }

  public int Id { get; set; }
  public string Name { get; set; }
  public int MainMenuItemId { get; set; }
}
