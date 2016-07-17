using System.Collections.Generic;
using SportsStore.Abstract;

namespace SportsStore.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private SportsStoreEFDbContext dbContext = new SportsStoreEFDbContext();
        public IEnumerable<Product> Products => dbContext.Products;
    }
}