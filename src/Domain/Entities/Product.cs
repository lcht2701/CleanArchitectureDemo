using System.Text.Json.Serialization;

namespace CleanArchitecture.Domain.Entities;
public class Product : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? Price { get; set; }
    public double? OldPrice { get; set; }
    public int? ProductCategoryId { get; set; }
    public int Status { get; set; }
    public string? Contents { get; set; }
}
