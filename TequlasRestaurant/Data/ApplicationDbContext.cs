using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TequlasRestaurant.Models.DomainModels;

namespace TequlasRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //set the database table
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<ProductIngredient> ProductIngredients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Define Product Ingredient composite key and relationships
            modelBuilder.Entity<ProductIngredient>().HasKey(pi => new { pi.ProductId, pi.IngredientId });

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.ProductIngredients)
                .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<ProductIngredient>()
                .HasOne(pi => pi.ingredient)
                .WithMany(i => i.ProductIngredients)
                .HasForeignKey(p => p.ProductId);


            //seed data

            modelBuilder.Entity<Category>().HasData(
                //add restaurant category here
                new Category { CategoryId = 1, Name = "Appetizer" },
                new Category { CategoryId = 2, Name = "Entree" },
                new Category { CategoryId = 3, Name = "Side Dish" },
                new Category { CategoryId = 4, Name = "Dessert" },
                new Category { CategoryId = 5, Name = "Beverage" }
                );



            modelBuilder.Entity<Ingredient>().HasData(
                //add restaurant Ingredients here
                new Ingredient { IngredientId = 1, Name = "Beef" },
                new Ingredient { IngredientId = 2, Name = "Chicken" },
                new Ingredient { IngredientId = 3, Name = "Fish" },
                new Ingredient { IngredientId = 4, Name = "Tortilla" },
                new Ingredient { IngredientId = 5, Name = "lettuce" },
                new Ingredient { IngredientId = 6, Name = "Tomato" }
                );


            modelBuilder.Entity<Product>().HasData(
                //add restaurant food entries here
                new Product
                {
                    ProductId = 1,
                    Name = "Appetizer",
                    Description = "A delicious Beef taco",
                    Price = 2.50m,
                    Stock = 100,
                    CategoryId = 2,
                },

                new Product
                {
                    ProductId = 2,
                    Name = "Chicken Taco",
                    Description = "A delicious Chicken taco",
                    Price = 1.99m,
                    Stock = 100,
                    CategoryId = 2,
                },

                new Product
                {
                    ProductId = 3,
                    Name = "Fish Taco",
                    Description = "A delicious Fish taco",
                    Price = 3.99m,
                    Stock = 100,
                    CategoryId = 2,
                }
                );

            //modelBuilder.Entity<ProductIngredient>().HasData(
            //    new ProductIngredient { ProductId = 1, IngredientId = 1 },

            //    new ProductIngredient { ProductId = 1, IngredientId = 4 },
            //    new ProductIngredient { ProductId = 1, IngredientId = 5 },
            //    new ProductIngredient { ProductId = 1, IngredientId = 6 },

            //    new ProductIngredient { ProductId = 2, IngredientId = 2 },
            //    new ProductIngredient { ProductId = 2, IngredientId = 4 },
            //    new ProductIngredient { ProductId = 2, IngredientId = 5 },
            //    new ProductIngredient { ProductId = 2, IngredientId = 5 },


            //     new ProductIngredient { ProductId = 3, IngredientId = 3 },
            //    new ProductIngredient { ProductId = 3, IngredientId = 4 },
            //    new ProductIngredient { ProductId = 3, IngredientId = 5 },
            //    new ProductIngredient { ProductId = 3, IngredientId = 6 }
            //    );
        }
    }
}
