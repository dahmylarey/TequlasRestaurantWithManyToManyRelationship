namespace TequlasRestaurant.Models.DomainModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        //foreignKey property
        public string? UserId { get; set; }

        //navigation property   
        public ApplicationUser User { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
