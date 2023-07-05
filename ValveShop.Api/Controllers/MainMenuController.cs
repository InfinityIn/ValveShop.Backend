using Microsoft.AspNetCore.Mvc;
using ValveShop.Api.Extensions;
using ValveShop.Storage.Entities.Layout;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class MainMenuController : ControllerBase
{
    private readonly ILogger<MainMenuController> _logger;

    public MainMenuController(ILogger<MainMenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMainMenu")]
    public IEnumerable<MainMenuItem> GetMainMenu()
    {
        _logger.LogTrace("������� ������ �� ������ ��������� �������� ����.");
        return StorageEntitiesExtensions.DefaultMainMenuItems();
    }
}
