using System.Net.Mime;
using backend_famLogitech_aw.Farms.Domain.Model.Queries.Shed;
using backend_famLogitech_aw.Farms.Domain.Services;
using backend_famLogitech_aw.Farms.Interfaces.REST.Resources.Shed;
using backend_famLogitech_aw.Farms.Interfaces.REST.Transform.Shed;
using Microsoft.AspNetCore.Mvc;

namespace backend_famLogitech_aw.Farms.Interfaces.REST.Transform;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ShedController(IShedCommandService shedCommandService, IShedQueryService shedQueryService)
    : ControllerBase

{
    [HttpPost]
    public async Task<ActionResult> CreateShedSource([FromBody] CreateShedResource resource)
    {
        var createShedCommand = CreateShedCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await shedCommandService.Handle(createShedCommand);
        return CreatedAtAction(nameof(GetShedById), new { id = result.Id },
            ShedResourceFromEntityAssembler.ToResourceFromEntity(result));
    }
    
    
    
    [HttpGet("{id}")]
    public async Task<ActionResult> GetShedById(int id)
    {
        var getFarmByIdQuery = new GetShedByIdQuery(id);
        var result = await shedQueryService.Handle(getFarmByIdQuery);
        var resource = ShedResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }
    [HttpGet("shed/all")]
    public async Task<ActionResult> GetAllSheds()
    {        
        var getAllShed = new GetAllShedQuery();
        var result = await shedQueryService.Handle(getAllShed);
        var resources = result.Select(ShedResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
}