namespace TequlasRestaurant.Models.DomainModels
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }

        //foreign key properties
        public Order? Order { get; set; }
        public int ProductId { get; set; }

        //foreign key properties
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
