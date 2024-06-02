using backend_famLogitech_aw.Crops.Domain.Model.Commands;
using backend_famLogitech_aw.Crops.Domain.Model.Queries;
using backend_famLogitech_aw.Crops.Domain.Services;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Resources;
using backend_famLogitech_aw.Crops.Interfaces.Rest.Transform;
using backend_famLogitech_aw.Farms.Interfaces.REST.Transform.Farm;
using Microsoft.AspNetCore.Mvc;

namespace backend_famLogitech_aw.Crops.Interfaces;

[ApiController]
[Route("api/v1/[controller]")]
[Produces("application/json")]
public class CropController : ControllerBase
{
    private ICropQueryService _cropQueryService;
    private ICropCommandService _cropCommandService;
    
    public CropController(ICropQueryService cropQueryService, ICropCommandService cropCommandService)
    {
        _cropQueryService = cropQueryService;
        _cropCommandService = cropCommandService;
    }
    
    [HttpPost]
    public async Task<ActionResult> CreateCrop([FromBody] CreateCropResource resource)
    {
        var createAnimalCommand = CreateCropCommandFromResourceAssembler.ToCommandFromResource(resource);
        var animal = await _cropCommandService.Handle(createAnimalCommand);
        return CreatedAtAction(nameof(GetCropById), new { id = animal.Id }, 
            CropResourceFromEntityAssembler.ToResourceFromEntity(animal));
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult> GetCropById(int id)
    {
        var query = new GetCropByIdQuery(id);
        var result = await _cropQueryService.Handle(query);
        var resource = CropResourceFromEntityAssembler.ToResourceFromEntity(result);
        return Ok(resource);
    }

    [HttpGet("crops/all")]
    public async Task<ActionResult> GetAllCrops()
    {
        var query = new GetAllCropsQuery();
        var result = await _cropQueryService.Handle(query);
        var resources = result.Select(CropResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateCrop( [FromBody] UpdateCropResource resource)
    {
        var updateCropcommand = UpdateCropCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await _cropCommandService.Handle(updateCropcommand);
        return Ok(CropResourceFromEntityAssembler.ToResourceFromEntity(result));
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCrop([FromBody] DeleteCropResource resource)
    {
        var deleteCropCommand = DeleteCropCommandFromResourceAssembler.ToCommandFromResource(resource);
        var result = await _cropCommandService.Handle(deleteCropCommand);
        return Ok(CropResourceFromEntityAssembler.ToResourceFromEntity(result));
    }
    
    
    

}