using backend_famLogitech_aw.profiles.Domain.Model.Aggregates;

namespace backend_famLogitech_aw.profiles.Domain.Services;

public interface IProfileCommandService
{
    Task<Profile> Handle(User command);

}