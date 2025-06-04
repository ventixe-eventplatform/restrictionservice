using WebApi.Data.Entities;
using WebApi.Models;

namespace WebApi.Factories;

public static class RestrictionFactory
{
    public static RestrictionModel Create(RestrictionEntity entity)
    {
        return new RestrictionModel
        {
            Id = entity.Id,
            ImageUrl = entity.ImageUrl,
            Description = entity.Description
        };
    }
}
