using System;
using System.Collections.Generic;
using DiUsingUnity.Models;

namespace DiUsingUnity.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<Product> Getproducts();
    }
}
