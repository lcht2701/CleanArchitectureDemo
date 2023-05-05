using CleanArchitecture.Application.Products.Commands.CreateProduct;
using CleanArchitecture.Application.Products.Queries.GetProducts;
using CleanArchitecture.Application.TodoLists.Commands.CreateTodoList;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers;
public class ProductsController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ProductsVm>> Get()
    {
        return await Mediator.Send(new GetProductsQuery());
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateProductCommand command)
    {
        return await Mediator.Send(command);
    }
}
