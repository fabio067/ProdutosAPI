using ProdutosAPI.Models;
using System.Collections.Generic;

namespace ProdutosAPI.Data
{
    public static class ProductData
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Naruto Vol. 1",
                    Price = 19.99m,
                    Genre = "Ação",
                    Image = "Images/naruto_vol1.jpg",
                    Description = "A história do jovem ninja Naruto Uzumaki."
                },
                new Product
                {
                    Id = 2,
                    Name = "One Piece Vol. 1",
                    Price = 22.99m,
                    Genre = "Aventura",
                    Image = "Images/onepiece_vol1.jpg",
                    Description = "A aventura épica de Luffy em busca do One Piece."
                },
                new Product
                {
                    Id = 3,
                    Name = "Attack on Titan Vol. 1",
                    Price = 24.99m,
                    Genre = "Drama",
                    Image = "Images/attackontitan_vol1.jpg",
                    Description = "Os humanos lutam pela sobrevivência contra titãs."
                }
            };
        }
    }
}