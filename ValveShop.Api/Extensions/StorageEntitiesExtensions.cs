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
  }
}
