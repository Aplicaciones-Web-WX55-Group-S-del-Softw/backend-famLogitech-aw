using backend_famLogitech_aw.Animals.Domain.Model.Aggregates;
using backend_famLogitech_aw.Animals.Domain.Model.Commands;
using backend_famLogitech_aw.Animals.Domain.Repositories;
using backend_famLogitech_aw.Animals.Domain.Services;
using backend_famLogitech_aw.Shared.Domain.Repositories;
using Mysqlx.Crud;

namespace backend_famLogitech_aw.Animals.Application.Internal.CommandServices;

public class AnimalCommandService : IAnimalCommandService
{
    private readonly IAnimalRepository _animalRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AnimalCommandService(IAnimalRepository animalRepository, IUnitOfWork unitOfWork)
    {
        this._animalRepository = animalRepository;
        this._unitOfWork = unitOfWork;
    }

    public async Task<Animal> Handle(CreateAnimalCommand command)
    {
        var animalnew = await _animalRepository.FindByIdAsync(command.Id); 
        if (animalnew != null)
            throw new Exception("Animal with ID already exists");
        animalnew = new Animal(command);
        await _animalRepository.AddAsync(animalnew);
        await _unitOfWork.CompleteAsync();
        return animalnew; 

    }

    public async Task<Animal> Handle(UpdateAnimalCommand command)
    {
        var animalupdate = await _animalRepository.FindByIdAsync(command.Id);
        if (animalupdate == null)
            throw new Exception("Animal with ID does not exist");
        animalupdate.Update(command);
        await _unitOfWork.CompleteAsync();
        return animalupdate;
    }

    public async Task<Animal> Handle(DeleteAnimalCommand command)
    {
        var animalToDelete = await _animalRepository.FindByIdAsync(command.Id);
        if (animalToDelete == null)
            throw new Exception("Animal with ID does not exist");
        await _animalRepository.DeleteAsync(animalToDelete);
        await _unitOfWork.CompleteAsync();
        return animalToDelete;
    }

    public async Task<Animal> Handle(ReadAnimalCommand command)
    {
        var animalToRead = await _animalRepository.FindByIdAsync(command.Id);
        if (animalToRead == null)
            throw new Exception("Animal with ID does not exist");
        animalToRead.Read(command);
        await _unitOfWork.CompleteAsync();
        return animalToRead;
    }
}