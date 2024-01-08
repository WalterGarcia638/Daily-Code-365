using Microsoft.AspNetCore.Mvc;
using ProductsCrud.model;
using System.Collections.Generic;


namespace ProductsCrud.Controller
{
   using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products = new()
    {
        new Product { ProductId = 1, Name = "Producto A", Price = 100, ProductCategoryId = 1, DateAdded = DateTime.Now, IsAvailable = true },
        new Product { ProductId = 2, Name = "Producto B", Price = 200, ProductCategoryId = 2, DateAdded = DateTime.Now, IsAvailable = true },
        // Agregar más productos aquí
    };

    [HttpGet]
    public ActionResult<List<Product>> GetProducts()
    {
        return Products;
    }

    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = Products.Find(p => p.ProductId == id);
        if (product == null)
        {
            return NotFound();
        }
        return product;
    }

    [HttpPost]
    public ActionResult<Product> PostProduct(Product product)
    {
        product.ProductId = Products.Count + 1; // Simple ID assignment, not suitable for production
        Products.Add(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
    }

    [HttpPut("{id}")]
    public ActionResult PutProduct(int id, Product product)
    {
        var index = Products.FindIndex(p => p.ProductId == id);
        if (index == -1)
        {
            return NotFound();
        }
        Products[index] = product;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        var product = Products.Find(p => p.ProductId == id);
        if (product == null)
        {
            return NotFound();
        }
        Products.Remove(product);
        return NoContent();
    }
}

}
