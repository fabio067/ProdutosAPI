using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProdutosAPI.Data;

namespace ProdutosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = ProductData.GetProducts();

        private static List<CartItem> cart = new List<CartItem>();

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }
        // POST: api/products/addtocart/{id}
        [HttpPost("addtocart/{id}")]
        public IActionResult AddToCart(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound("Produto não encontrado");
            }

            var cartItem = cart.FirstOrDefault(c => c.ProductId == id);

            if (cartItem != null)
            {
                cartItem.Quantity++; // Incrementa a quantidade se já existir no carrinho
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = 1
                });
            }

            return Ok(cart);
        }
        // GET: api/products/cart
        [HttpGet("cart")]
        public ActionResult<IEnumerable<CartItem>> GetCartItems()
        {
            return Ok(cart);
        }
    }
}

