using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ValveShop.Storage.Entities.Layout;
public class OrderListItem
{
    public OrderListItem(int id, string name, int price, int amount, int discount, int discountPrice, string article)
    {
        Id = id;
        Name = name;
        Price = price;
        Amount = amount;
        Discount = discount;
        DiscountPrice = discountPrice;
        Article = article;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Amount { get; set; }
    public int Discount { get; set; }
    public int DiscountPrice { get; set; }
    public string Article { get; set; }
}