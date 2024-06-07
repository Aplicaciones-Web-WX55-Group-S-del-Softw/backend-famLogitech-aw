using backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;
using backend_famLogitech_aw.Ratings.Domain.Model.Commands;

namespace backend_famLogitech_aw.Ratings.Domain.Services;

public interface IRatingCommandService
{ 
    Task<Rating> Handle(CreateRatingCommand command);
    Task<Rating> Handle(UpdateRatingCommand command);
}
