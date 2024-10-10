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

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }
    }
}