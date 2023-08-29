using Domain.Service;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("[controller]")]
public class CoffeeBrandController : ControllerBase
{
    private readonly ICoffeeBrandService _coffeeBrandService;

    public CoffeeBrandController(ICoffeeBrandService coffeeBrandService)
    {
        _coffeeBrandService = coffeeBrandService;
    }

    [HttpGet("GetHex")]
    public IEnumerable<CoffeeBrandModel> Get()
    {
        return _coffeeBrandService.GetCoffeeBrands();
    }

}
