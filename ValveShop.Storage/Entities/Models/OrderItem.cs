using System.Diagnostics;

namespace ValveShop.Storage.Entities.Models;
public class OrderItem
{
    public OrderItem(int id, string name, int price, int amount, int discount, int discountPrice, string article)
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