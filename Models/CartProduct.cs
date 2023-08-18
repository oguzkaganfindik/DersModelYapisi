namespace DersModelYapisi.Models
{
    public class CartProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
