using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers;

[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repo;

    public ProductsController(IProductRepository productRepo)
    {
        _repo = productRepo;
    }

    [HttpGet(ApiEndpoints.Products.GetAll)]
    public async Task<ActionResult<List<Product>>> GetAll()
    {
        return Ok(await _repo.GetProductsAsync());
    }

    [HttpGet(ApiEndpoints.Products.Get)]
    public async Task<ActionResult<Product>> Get(int productId)
    {
        return await _repo.GetProductByIdAsync(productId);
    }
}
