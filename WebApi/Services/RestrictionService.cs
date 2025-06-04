using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Factories;
using WebApi.Models;

namespace WebApi.Services;

public class RestrictionService(DataContext context) : IRestrictionService
{
    public readonly DataContext _context = context;

    public async Task<IEnumerable<RestrictionModel>> GetRestrictionsAsync()
    {
        var entities = await _context.Restrictions.ToListAsync();

        return entities.Select(RestrictionFactory.Create);
    }
}
