using System.Collections.Generic;
using System.Linq;

namespace SportsStore
{
    public class Cart
    {
        private List<CartProduct> cartProducts = new List<CartProduct>();

        public IEnumerable<CartProduct> CartProducts => cartProducts;

        public void AddItem(Product product, int quantity)
        {
            CartProduct cartProduct = cartProducts.FirstOrDefault(p => p.Product.ProductId == product.ProductId);
            if (cartProduct == null)
            {
                cartProducts.Add(new CartProduct { Product = product, Quantity = quantity });
            }
            else
            {
                cartProduct.Quantity += quantity;
            }
        }

        public void RemoveItem(Product product)
        {
            cartProducts.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }

        public decimal ComputeTotalValue()
        {
            return cartProducts.Sum(p => p.Quantity * p.Product.Price);
        }

        public void Clear()
        {
            cartProducts.Clear();
        }
    }
}