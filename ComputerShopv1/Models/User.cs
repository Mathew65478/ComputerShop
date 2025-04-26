namespace ComputerShopAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsRegistered { get; set; }
        public int LoyaltyPoints { get; set; }
        public string LoyaltyLevel { get; set; }
    }
}
