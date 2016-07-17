using System.Collections;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public class ProductListViewModel : IEnumerable
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}