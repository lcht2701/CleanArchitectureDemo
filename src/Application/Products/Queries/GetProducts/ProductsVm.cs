using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.TodoLists.Queries.GetTodos;

namespace CleanArchitecture.Application.Products.Queries.GetProducts;
public class ProductsVm
{
    public IReadOnlyCollection<ProductDto> Lists { get; init; } = Array.Empty<ProductDto>();
}
