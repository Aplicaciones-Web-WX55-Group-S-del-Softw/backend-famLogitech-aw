using backend_famLogitech_aw.Ratings.Domain.Model.Commands;
using backend_famLogitech_aw.Ratings.Interfaces.REST.Resources;

namespace backend_famLogitech_aw.Ratings.Interfaces.REST.Transform;

public static class UpdateRatingCommandFromResourceAssembler
{
    public static UpdateRatingCommand ToCommandFromResource(UpdateRatingResource resource)
    {
        return new UpdateRatingCommand(resource.Id, resource.StarRating, resource.UserId);
    }
}