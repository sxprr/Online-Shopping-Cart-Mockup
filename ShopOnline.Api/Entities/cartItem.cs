namespace ShopOnline.Api.Entities
{
    public class cartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int productId { get; set; }
        public int Qty { get; set; }
    }
}
