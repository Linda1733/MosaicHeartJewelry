using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosaicHeartJewelry.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name="Necklace", Price=35 },
            new Product {Name="Bracelet", Price=25 },
            new Product {Name="Earrings", Price=15 }
        }.AsQueryable<Product>();
    }    
}
