using backend_famLogitech_aw.Farms.Domain.Model.Aggregates;

namespace backend_famLogitech_aw.Farms.Domain.Model.Commands;

public record PutFarmIdQuery(int Id, Farm UpdatedFarm);