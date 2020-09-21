using System;
using System.Collections.Generic;
using DiUsingUnity.Interfaces;
using DiUsingUnity.Models;

namespace DiUsingUnity
{
    public class MainViewModel
    {
        private readonly IProductsService _productsService;
        public IEnumerable<Product> Products { get; set; }

        public MainViewModel(IProductsService productsService)
        {
            _productsService = productsService;
            DownloadProducts();
        }
        public void DownloadProducts()
        {
            Products = _productsService.Getproducts();
        }
    }
}
