using DiUsingUnity.Interfaces;
using DiUsingUnity.Models;
using System.Collections.Generic;
namespace DiUsingUnity.Services
{
    public class ProductsService : IProductsService
    {
        public IEnumerable<Product> Getproducts()
        {
            return new List<Product>
            {
                new Product { Name = "Mac Laptop", Price = 1500 },
                new Product { Name = "Dell One", Price = 1400 },
            };
        }

    }
}
