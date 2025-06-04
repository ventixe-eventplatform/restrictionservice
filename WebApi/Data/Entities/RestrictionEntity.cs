using System.ComponentModel.DataAnnotations;

namespace WebApi.Data.Entities;

public class RestrictionEntity
{
    [Key]
    public int Id { get; set; }
    public string? ImageUrl { get; set; }
    public string Description { get; set; } = null!;
}
