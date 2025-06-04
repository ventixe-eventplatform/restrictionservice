using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RestrictionsController(IRestrictionService restrictionService) : ControllerBase
{
    private readonly IRestrictionService _restrictionService = restrictionService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _restrictionService.GetRestrictionsAsync();
        return Ok(result);
    }
}
