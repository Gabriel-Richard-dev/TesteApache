using Microsoft.AspNetCore.Mvc;

namespace TesteApache.Controllers;

public class OiController : ControllerBase
{
    [HttpGet("oi")]
    public async Task<IActionResult> Oi()
    {
        return Ok("oi");
    }
    [HttpGet("tchau")]
    public async Task<IActionResult> tchau()
    {
        return Ok("tchau");
    }
    
}