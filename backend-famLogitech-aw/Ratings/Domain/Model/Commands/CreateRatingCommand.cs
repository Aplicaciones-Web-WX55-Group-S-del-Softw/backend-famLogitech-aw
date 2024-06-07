namespace backend_famLogitech_aw.Ratings.Domain.Model.Commands;

public record CreateRatingCommand(int Id, int StarRating, int UserId);