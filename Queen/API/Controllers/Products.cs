using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace API.Controllers;

[ApiController]
[Route("/api/[controller]")] //   api/products
public class ProductsController:ControllerBase
{
private readonly DataContex _context;
public ProductsController(DataContex contex)
{
    _context=contex;
}



[HttpGet]
public async Task<IActionResult> GetProducts(){
    var products = await _context.Products.ToListAsync();
    return Ok(products);
}

[HttpGet("{id}")]
public async Task<IActionResult> GetProduct(int id)
{
    if(id==null){
        return NotFound();
    }
    var product = await _context.Products.FindAsync(id);
    if(product==null){
        return NotFound();
    }
    return Ok(product);
}
    
}
