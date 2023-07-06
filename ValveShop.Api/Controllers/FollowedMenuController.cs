using Microsoft.AspNetCore.Mvc;
using ValveShop.Api.Extensions;
using ValveShop.Storage.Abstractions.Control;
using ValveShop.Storage.Entities.Layout;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class FollowedMenuController : ControllerBase
{
    private readonly ILogger<FollowedMenuController> _logger;

    public FollowedMenuController(ILogger<FollowedMenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFollowedMenu")]
    public IEnumerable<Control> GetFollowedMenu()
    {
        _logger.LogTrace("Получил запрос на список элементов вторичного меню меню.");
        return StorageEntitiesExtensions.DefaultFollowedMenuItems();
    }
}
