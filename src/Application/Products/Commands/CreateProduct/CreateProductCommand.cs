using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Products.Commands.CreateProduct;
public record CreateProductCommand : IRequest<int>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? Price { get; set; }
    public double? OldPrice { get; set; }
    public int? ProductCategoryId { get; set; }
    public string? Contents { get; set; }
}
public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product();

        entity.Name = request.Name;
        entity.Description = request.Description;
        entity.Price = request.Price;
        entity.OldPrice = request.OldPrice;
        entity.ProductCategoryId = request.ProductCategoryId;
        entity.Contents = request.Contents;

        _context.Products.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}