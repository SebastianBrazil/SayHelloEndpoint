using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
    public List<string> greet = new();

    public SayHelloController()
    {
        greet.Add("Hello, World.");
    }

    [HttpGet]
    [Route("SayHelloGeneric")]
    public List<string> SayHelloGeneric()
    {
        return greet;
    }

    [HttpPost]
    [Route("Personalize/{name}")]
    public List<string> Personalize(string name)
    {
        greet.Remove("Hello, World.");
        greet.Add($"Hello, {name}.");
        return greet;
    }
}
