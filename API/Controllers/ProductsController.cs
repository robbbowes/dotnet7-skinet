using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
public class ProductsController : ControllerBase
{
    private readonly StoreContext _context;

    public ProductsController(StoreContext context)
    {
        _context = context;
    }

    [HttpGet(ApiEndpoints.Products.GetAll)]
    public async Task<ActionResult<List<Product>>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }

    [HttpGet(ApiEndpoints.Products.Get)]
    public async Task<ActionResult<Product>> Get(int productId)
    {
        return await _context.Products.FindAsync(productId);
    }
}
