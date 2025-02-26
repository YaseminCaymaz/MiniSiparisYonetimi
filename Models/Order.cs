namespace MiniSiparisYonetimi.Models
{
    public class Order
    {
        public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderTime { get; set; }
    public decimal TotalPrice { get; set; }
    public string DiscountCode { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }

    }
}