namespace ComputerShopAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // np. "Nowe", "Wysłane", "Zrealizowane", "Anulowane"

        public User User { get; set; }
    }
}
