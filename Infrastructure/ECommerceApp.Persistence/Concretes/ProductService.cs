using ECommerceApp.Application.Abstractions;
using ECommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new(){Id=Guid.NewGuid(), Name="Product-1", Price=1000, Stock=10},
            new(){Id=Guid.NewGuid(), Name="Product-2", Price=2000, Stock=20},
            new(){Id=Guid.NewGuid(), Name="Product-3", Price=3000, Stock=30},
            new(){Id=Guid.NewGuid(), Name="Product-4", Price=4000, Stock=40},
            new(){Id=Guid.NewGuid(), Name="Product-5", Price=5000, Stock=50}
        };
    }
}
