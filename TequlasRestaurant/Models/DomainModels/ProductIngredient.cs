namespace TequlasRestaurant.Models.DomainModels
{
    public class ProductIngredient
    {
        //foreign key (Product)
        public int ProductId { get; set; }
        public Product Product { get; set; }


        //foreach (Ingredient)
        public int IngredientId { get; set; }
        public Ingredient ingredient { get; set; }

    }
}