using ProdutosAPI.Models;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

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
                    Name = "Solo Leveling",
                    Price = 19.99m,
                    Genre = "Murim",
                    Image = "/Images/solo.jpg",
                    Description = "Em um mundo onde humanos com habilidades mágicas, chamados de caçadores, lutam contra monstros para proteger a raça humana, Jin-woo se torna o único a subir de nível e parte em uma jornada para descobrir os segredos de sua quase morte e a origem de seus poderes"
                },
                new Product
                {
                    Id = 2,
                    Name = "One Piece",
                    Price = 22.99m,
                    Genre = "Aventura",
                    Image = "/Images/onepiece.jpg",
                    Description = "A aventura épica de Luffy em busca do One Piece."
                },
                new Product
                {
                    Id = 3,
                    Name = "Lookism",
                    Price = 24.99m,
                    Genre = "Escolar",
                    Image = "/Images/lookism.jpg",
                    Description = "Daniel é um solitário pouco atraente que acorda em um corpo diferente. Agora alto, bonito e mais legal do que nunca em sua nova forma, Daniel pretende alcançar tudo o que não conseguiu antes. Até onde ele irá para manter seu corpo… e seus segredos?"
                },
                new Product
                {
                    Id = 4,
                    Name = "Mayonaka no mangetsu",
                    Price = 10.99m,
                    Genre = "Mistério",
                    Image = "/Images/lobo.jpg",
                    Description = "Min Saki é um  órfão que teve seus anos roubados  por um reformatório na cidade Fuchū. Sem ter para onde ir e após ser rejeitado e abusado pela família adotiva, este assassinou seu pai de criação e agora se vê em meio a sobrevivência em um reformatório que esconde muito mais que os olhos podem ver."
                }
            };
        }
    }
}