using ValveShop.Storage.Entities.Layout;

namespace ValveShop.Api.Extensions
{
  public static class StorageEntitiesExtensions
  {
    public static IEnumerable<MainMenuItem> DefaultMainMenuItems()
    {
      yield return new MainMenuItem(1, "Клапаны");
      yield return new MainMenuItem(2, "Вентиляторы");
      yield return new MainMenuItem(3, "Заслонки");
      yield return new MainMenuItem(4, "Решетки");
      yield return new MainMenuItem(5, "Канальная группа");
    }

    public static IEnumerable<FollowedMenuItem> DefaultFollowedMenuItems()
    {
      yield return new FollowedMenuItem(1, "КДМ-2м", 1);
      yield return new FollowedMenuItem(2, "КДМ-3", 1);
      yield return new FollowedMenuItem(3, "КПС-1м(60)", 1);
      yield return new FollowedMenuItem(4, "КПС-1м(90)", 1);
      yield return new FollowedMenuItem(5, "КИД", 1);
    }
  }
}
