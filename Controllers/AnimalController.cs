using Microsoft.AspNetCore.Mvc;
using ZooManagement.Models.Response;
using ZooManagement.Repositories;
using ZooManagement.Models.Request;

[ApiController]
//[Route("/animals")]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
  
        private readonly IAnimalsRepo _animals;

        public AnimalController(IAnimalsRepo animals)
        {
            _animals = animals;
        }


// list of animals?
/*
    [HttpGet("")]
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
*/

//get by ID
	 [HttpGet("api/get-animal/{id}")]
        public ActionResult<AnimalResponse> GetById([FromRoute] int id)
        {
          /*  string authHeader = HttpContext.Request.Headers["Authorization"];
            if(!_animals.HasAccess(authHeader))
            {
                return Unauthorized();
            }
           */
            var animal = _animals.GetById(id);
            return new AnimalResponse(animal);
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] AnimalRequest newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var animal = _animals.Create(newAnimal);

            var url = Url.Action("GetById", new { id = animal.Id });
            var responseViewModel = new AnimalResponse(animal);
            return Created(url, responseViewModel);
        }

        [HttpGet("species")]
        public List<String> GetSpecies()
        {
            return _animals.GetSpecies();
        }
        
}
