using Microsoft.AspNetCore.Mvc;
using MiniSiparisYonetimi.Models;

namespace MiniSiparisYonetimi.Controllers;
// product
public class ProductController : Controller
{
    // product/index
    public IActionResult Index()
    {
        var product = new Product();
        product.Id = 1;
        product.Name = "Jeans";
        product.Description = "Denim";
        product.Price = 100;
        return View(product);
    }

    // product/list
     public IActionResult List()
    {
        var products = new List<Product>();
        products.Add(new Product() { Id = 1, Name = "Jeans", Description = "Denim Elbette, ürün kartlarını yan yana getirmek için CSS kullanmanız gerekiyor. Bunun için en yaygın ve esnek yöntemler Flexbox ve Grid'dir.", Price = 100 });
        products.Add(new Product() { Id = 2, Name = "Shirt", Description = "Cotton Elbette, ürün kartlarını yan yana getirmek için CSS kullanmanız gerekiyor. Bunun için en yaygın ve esnek yöntemler Flexbox ve Grid'dir.", Price = 50 });
        products.Add(new Product() { Id = 3, Name = "T-Shirt", Description = "Cotton Elbette, ürün kartlarını yan yana getirmek için CSS kullanmanız gerekiyor. Bunun için en yaygın ve esnek yöntemler Flexbox ve Grid'dir.", Price = 25 });
        products.Add(new Product() { Id = 3, Name = "T-Shirt", Description = "Cotton Elbette, ürün kartlarını yan yana getirmek için CSS kullanmanız gerekiyor. Bunun için en yaygın ve esnek yöntemler Flexbox ve Grid'dir.", Price = 25 });
        products.Add(new Product() { Id = 3, Name = "T-Shirt", Description = "Cotton Elbette, ürün kartlarını yan yana getirmek için CSS kullanmanız gerekiyor. Bunun için en yaygın ve esnek yöntemler Flexbox ve Grid'dir.", Price = 25 });
        products.Add(new Product() { Id = 3, Name = "T-Shirt", Description = "Cotton ", Price = 25 });


        return View(products);
    }
}