using WebApi.Models;

namespace WebApi.Services;

public interface IRestrictionService
{
    Task<IEnumerable<RestrictionModel>> GetRestrictionsAsync();
}
