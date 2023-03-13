using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models;

[ApiController]
[Route("/animals")]
public class AnimalController : ControllerBase
{
  /*  private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
*/
    private readonly ILogger<AnimalController> _logger;

    public AnimalController(ILogger<AnimalController> logger)
    {
        _logger = logger;
    }


    [HttpGet("{id}")]
    public IEnumerable<Animal> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Animal
        {
            // Date = DateTime.Now.AddDays(index),
            // TemperatureC = Random.Shared.Next(-20, 55),
            // Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
