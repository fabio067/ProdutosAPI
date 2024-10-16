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

        // GET: api/products/cart
        [HttpGet("cart")]
        public ActionResult<IEnumerable<CartItem>> GetCartItems()
        {
            return Ok(cart ?? new List<CartItem>());
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

            // Recalcula o total
            var total = cart.Sum(item => item.Price * item.Quantity);

            return Ok(new { Cart = cart, Total = total });
        }

        // POST: api/products/incrementcart/{id}
        [HttpPost("incrementcart/{id}")]
        public IActionResult IncrementCartItem(int id)
        {
            var cartItem = cart.FirstOrDefault(c => c.ProductId == id);

            if (cartItem == null)
            {
                return NotFound("Item não encontrado no carrinho");
            }

            cartItem.Quantity++; // Incrementa a quantidade

            // Recalcula o total
            var total = cart.Sum(item => item.Price * item.Quantity);

            return Ok(new { Cart = cart, Total = total });
        }

        // POST: api/products/decrementcart/{id}]
        [HttpPost("decrementcart/{id}")]
        public IActionResult DecrementCartItem(int id)
        {
            var cartItem = cart.FirstOrDefault(c => c.ProductId == id);

            if (cartItem == null)
            {
                return NotFound("Item não encontrado no carrinho");
            }

            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--; // Decrementa a quantidade
            }
            else
            {
                cart.Remove(cartItem); // Remove o item se a quantidade for 1
            }

            // Recalcula o total
            var total = cart.Sum(item => item.Price * item.Quantity);

            return Ok(new { Cart = cart, Total = total });
        }
    }
}