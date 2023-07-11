using Microsoft.AspNetCore.Mvc;
using ValveShop.Api.Extensions;
using ValveShop.Storage.Abstractions.Control;
using ValveShop.Storage.Entities.Layout;
using ValveShop.Storage.Entities.Models;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderItemsController : ControllerBase
{
    private readonly ILogger<OrderItemsController> _logger;

    public OrderItemsController(ILogger<OrderItemsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetOrderItems")]
    public IEnumerable<OrderItem> GetOrderItem()
    {
        _logger.LogTrace("ѕолучил запрос на список элементов управлени€ свойствами продукта.");
        return StorageEntitiesExtensions.DefaultOrderItems();
 
    }
}
