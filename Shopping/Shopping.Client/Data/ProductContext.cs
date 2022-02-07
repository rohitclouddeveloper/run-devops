using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
        new Product()
        {
            Name = "Product 1",
            Description = "This phone is product 1",
            ImageFile = "product-1.png",
            Price = 950.00M,
            Category= "Smart Phone"
        },
        new Product()
        {
            Name = "Product 2",
            Description = "This phone is product 2",
            ImageFile = "product-2.png",
            Price = 40.00M,
            Category= "Non Smart Phone"
        },
        new Product()
        {
            Name = "Product 3",
            Description = "This phone is product 3",
            ImageFile = "product-3.png",
            Price = 402.00M,
            Category= "Smart Phone"
        },
        new Product()
        {
            Name = "Product 4",
            Description = "This phone is product 4",
            ImageFile = "product-4.png",
            Price = 158.00M,
            Category= "Smart Phone"
        },
        new Product()
        {
            Name = "Product 5",
            Description = "This phone is product 5",
            ImageFile = "product-5.png",
            Price = 10.00M,
            Category= "Non Smart Phone"
        }
    };
    }
}
