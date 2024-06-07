using System.Runtime.Versioning;
using backend_famLogitech_aw.Ratings.Domain.Model.Commands;

namespace backend_famLogitech_aw.Ratings.Domain.Model.Aggregates;

public class Rating
{
    public int Id { get; private set; }
    public int StarRating { get; set; }
    public int UserId { get; set; }

    protected Rating()
    {
        this.Id = 0;
        this.StarRating = 0;
        this.UserId = 0;
    }

    public Rating(CreateRatingCommand command)
    {
        this.Id = command.Id;
        this.StarRating = command.StarRating;
        this.UserId = command.UserId;
    }

    public void Update(UpdateRatingCommand command)
    {
        this.StarRating = command.StarRating;
        this.UserId = command.UserId;
    }
}