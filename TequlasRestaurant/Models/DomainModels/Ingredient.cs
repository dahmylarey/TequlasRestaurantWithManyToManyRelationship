namespace TequlasRestaurant.Models.DomainModels
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }


        //navigation properties
        public ICollection<ProductIngredient> ProductIngredients { get; set; }


    }
}