namespace SportsStore
{
    public class CartProduct
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
