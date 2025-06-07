using Kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ClientController(IDbService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        return Ok(await service.GetAllClinetsAsync());
    }
}