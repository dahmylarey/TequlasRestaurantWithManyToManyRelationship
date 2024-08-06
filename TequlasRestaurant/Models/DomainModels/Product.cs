namespace TequlasRestaurant.Models.DomainModels
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int Stock { get; set; }

        //foreign key properties
        public int CategoryId { get; set; }
        public Category Category { get; set; }//A product belongs to a category


        //navigation properties
        public ICollection<OrderItem> orderItems { get; set; }//A product can have many order items
        public ICollection<ProductIngredient> ProductIngredients { get; set; }//A product can have many order items
    }
}