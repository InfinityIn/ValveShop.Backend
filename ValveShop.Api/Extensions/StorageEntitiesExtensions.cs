using ValveShop.Storage;
using ValveShop.Storage.Abstractions;
using ValveShop.Storage.Abstractions.Control;
using ValveShop.Storage.Entities.Layout;
using ValveShop.Storage.Entities.Layout.Controls;
using ValveShop.Storage.Entities.Models;

namespace ValveShop.Api.Extensions
{
    public static class StorageEntitiesExtensions
    {
        public static IEnumerable<Control> DefaultMainMenuItems()
        {
            using (StorageContext db = new StorageContext())
            {
                yield return new LabelControl(4, "", ControlPlacementType.MainMenu, "Решетки");
                yield return new LabelControl(6, "", ControlPlacementType.MainMenu, "Клапан");
                yield return new LabelControl(8, "", ControlPlacementType.MainMenu, "Заслонка");

                db.SaveChanges();
            }
                                    
        }

        public static IEnumerable<Control> DefaultFollowedMenuItems()
        {
            using (StorageContext db = new StorageContext())
            {
                yield return new LabelControl(7, "", ControlPlacementType.MainMenu, "Решетки");
                yield return new LabelControl(9, "", ControlPlacementType.MainMenu, "Заслонка");
                yield return new LabelControl(4, "", ControlPlacementType.MainMenu, "Клапан");

                db.SaveChanges();
            }
        }

        public static IEnumerable<Control> DefaultProductPropertyItems()
        {
            using (StorageContext db = new StorageContext())
            {
                yield return new CheckBoxControl(1, "Клапаны", ControlPlacementType.MainMenu, true);
                yield return new ImageControl(3, "Заслонки", ControlPlacementType.MainMenu, "https://sun1-98.userapi.com/impg/svZCA4HbrqVRhKgSwNCcEom-MZeNuUeEQ-qVAg/vm057EOvJRo.jpg?size=1080x1080&quality=95&sign=ef0a01d8b78e24a4a941b6597af45ed7&type=album");
                yield return new LabelControl(4, "", ControlPlacementType.MainMenu, "Решетки");

                db.SaveChanges();
            }
        }
        public static IEnumerable<Control> DefaultMenuControlItems()
        {
            using (StorageContext db = new StorageContext())
            {
                yield return new CheckBoxControl(1, "Клапаны", ControlPlacementType.MainMenu, true);
                yield return new ImageControl(3, "Заслонки", ControlPlacementType.MainMenu, "https://sun1-98.userapi.com/impg/svZCA4HbrqVRhKgSwNCcEom-MZeNuUeEQ-qVAg/vm057EOvJRo.jpg?size=1080x1080&quality=95&sign=ef0a01d8b78e24a4a941b6597af45ed7&type=album");
                yield return new LabelControl(4, "", ControlPlacementType.MainMenu, "Решетки");

                db.SaveChanges();
            }
        }
        public static IEnumerable<OrderItem> DefaultOrderItems()
        {
            using (StorageContext db = new StorageContext())
            {

                yield return new OrderItem(1, "Клапан", 500, 2, 10, 20, "011111111111111");
                yield return new OrderItem(2, "Решетка", 400, 2, 10, 20, "011111111111111");
                yield return new OrderItem(3, "Заслонка", 500, 2, 10, 20, "011111111111111");
                
                db.SaveChanges();
            }
        }
    }
}
