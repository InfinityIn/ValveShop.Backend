using Microsoft.AspNetCore.Mvc;
using ValveShop.Api.Extensions;
using ValveShop.Storage.Abstractions.Control;
using ValveShop.Storage.Entities.Layout;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductPropertyController : ControllerBase
{
    private readonly ILogger<ProductPropertyController> _logger;

    public ProductPropertyController(ILogger<ProductPropertyController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProductProperty")]
    public IEnumerable<Control> Get()
    {
        _logger.LogTrace("ѕолучил запрос на список элементов управлени€ свойствами продукта.");
        return StorageEntitiesExtensions.DefaultProductPropertyItems();
    }
}
