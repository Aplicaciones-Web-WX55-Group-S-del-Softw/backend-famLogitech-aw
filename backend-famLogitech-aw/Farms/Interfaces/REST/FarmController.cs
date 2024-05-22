using System.Net.Mime;
using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;
using backend_famLogitech_aw.Farms.Domain.Model.Commands;
using backend_famLogitech_aw.Farms.Domain.Model.Queries;
using backend_famLogitech_aw.Farms.Domain.Services;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources;
using backend_famLogitech_aw.Farms.Interfaces.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend_famLogitech_aw.Farms.Interfaces.REST;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class FarmController(IFarmCommandService farmCommandService, IFarmQueryService farmQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateFarmSource([FromBody] CreateFarmResource resource)
    {
        var createFarmCommand = CreateFarmCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await farmCommandService.Handle(createFarmCommand);
        return CreatedAtAction(nameof(GetFarmById), new { id = result.Id },
            FarmResourceFromEntityAssembler.ToResourceFromEntity(result));
    }
    
    
    [HttpGet("{id}")]
    public async Task<ActionResult> GetFarmById(int id)
    {
        var getFarmByIdQuery = new GetFarmByIdQuery(id);
        var result = await farmQueryService.Handle(getFarmByIdQuery);
        var resource = FarmResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }

    
    [HttpGet("location/{location}")]
    public async Task<ActionResult> GetAllFarmByLocation(string location)
    {
        var getAllFarmByLocationQuery = new GetFarmByLocationQuery(location);
        var result = await farmQueryService.Handle(getAllFarmByLocationQuery);
        var resources = result.Select(FarmResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
    [HttpGet("all")]
    public async Task<ActionResult> GetAllFarms()
    {        
        var getAllFarms = new GetAllFarmQuery();
        var result = await farmQueryService.Handle(getAllFarms);
        var resources = result.Select(FarmResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
    [HttpPut("{id}")]
    /* CreateFarmSource([FromBody] CreateFarmResource resource)*/
    public async Task<ActionResult> UpdateFarm(int id,[FromBody] UpdateFarmCommand  updatedFarm)
    {
        
        var createFarmCommand = CreateFarmCommandFromResourceAssembler.ToCommandFromResource(resource);

        var putFarmCommand  =  UpdateFarmCommandFr(id, updatedFarm);
        var result = await farmQueryService.Handle(putFarmByIdQuery);
        var resource = FarmResourceFromEntityAssembler.ToResourceFromEntity(result);
        
        return Ok(resource);
    }
}
