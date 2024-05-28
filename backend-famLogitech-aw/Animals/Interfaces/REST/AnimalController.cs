using System.Net.Mime;
using backend_famLogitech_aw.Animals.Domain.Model.Commands;
using backend_famLogitech_aw.Animals.Domain.Model.Queries;
using backend_famLogitech_aw.Animals.Domain.Services;
using backend_famLogitech_aw.Animals.Interfaces.Resources;
using backend_famLogitech_aw.Animals.Interfaces.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend_famLogitech_aw.Animals.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class AnimalController : ControllerBase
{
    private IAnimalQueryService _animalQueryService;
    private IAnimalCommandService _animalCommandService;

    public AnimalController(IAnimalQueryService animalQueryService, IAnimalCommandService animalCommandService)
    {
        _animalQueryService = animalQueryService;
        _animalCommandService = animalCommandService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateAnimal([FromBody] CreateAnimalResource resource)
    {
        var createAnimalCommand = CreateAnimalCommandFromResourceAssembler.ToCommandFromResource(resource);
        var animal = await _animalCommandService.Handle(createAnimalCommand);
        return CreatedAtAction(nameof(GetAnimalByIdQuery), new { id = animal.Id }, 
            AnimalResourceFromEntityAssembler.ToResourceFromEntity(animal));
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult> GetAnimalById(int id)
    {
        var query = new GetAnimalByIdQuery(id);
        var result = await _animalQueryService.Handle(query);
        var resource = AnimalResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }
    
    [HttpGet("ShedId/{shedid}")]
    public async Task<ActionResult> GetAnimalByShedId(int shedid)
    {
        var query = new GetAnimalByShedIdQuery(shedid);
        var result = await _animalQueryService.Handle(query);
        var resource = AnimalResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }

    [HttpGet("animal/all")]
    public async Task<ActionResult> GetAllAnimals()
    {
        var query = new GetAllAnimalsQuery();
        var result = await _animalQueryService.Handle(query);
        var resources = result.Select(AnimalResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    

}