using backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;
using backend_famLogitech_aw.Ratings.Interfaces.REST.Resources;

namespace backend_famLogitech_aw.Ratings.Interfaces.REST.Transform;

public static class RatingResourceFromEntityAssembler
{
    public static RatingResource ToResourceFromEntity(Rating entity)
    {
        return new RatingResource(entity.Id, entity.StarRating, entity.UserId);
    }
}