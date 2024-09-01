using Microsoft.AspNetCore.Mvc;

namespace SampleLogger.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController :  ControllerBase
{
    private readonly ILogger<TestController> _logger;
    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        _logger.LogInformation("Test Controller called!");
        return Ok();
    } 
}
