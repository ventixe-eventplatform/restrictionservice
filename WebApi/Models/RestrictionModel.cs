namespace WebApi.Models;

public class RestrictionModel
{
    public int Id { get; set; }
    public string? ImageUrl { get; set; }
    public string Description { get; set; } = null!;
}
