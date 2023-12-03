using microserviceCRUD.Entities;
using microserviceCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace microserviceCRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingController : ControllerBase
{

    private readonly ICatalogService _catalogService;

    public BookingController(ICatalogService catalogService)
    {
        _catalogService = catalogService;
    }

    /// <summary>
    /// return all items
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(CatalogItem),200)]
    [ProducesResponseType(403)]
    public IEnumerable<CatalogItem> Get()
    {
        return _catalogService.GetAll();
    }
}