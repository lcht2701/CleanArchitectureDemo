using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Products.Queries.GetProducts;
public class ProductDto : IMapFrom<Product>
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? Price { get; set; }
}
