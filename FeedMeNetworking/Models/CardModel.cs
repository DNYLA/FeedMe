namespace FeedMeNetworking.Models
{
    public class CardModelOld
    {
        public string CardNum { get; set; } = string.Empty;
        public string ExpiryDate { get; set; } = string.Empty;
        public string CVC { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ExtraDetails { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}