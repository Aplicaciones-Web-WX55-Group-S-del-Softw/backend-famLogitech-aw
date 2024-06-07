namespace backend_famLogitech_aw.Ratings.Domain.Model.Commands;

public record UpdateRatingCommand(int Id, int StarRating, int UserId);