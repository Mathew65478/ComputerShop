namespace ComputerShopAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsCancelled { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
