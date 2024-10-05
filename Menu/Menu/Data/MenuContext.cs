using Microsoft.EntityFrameworkCore;
using Menu.Models;

namespace Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) :
            base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish)
                .WithMany(di => di.DishIngredients)
                .HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient)
                .WithMany(di => di.DishIngredients)
                .HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
               new Dish
               {
                   Id = 1,
                   Name = "Margheritta Pizza",
                   Price=7.50,
                   ImageUrl= "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.jocooks.com%2Frecipes%2Fmargherita-pizza%2F&psig=AOvVaw2xhYgI_GyxO_nEw_81Xliw&ust=1727885526192000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCIDQoqvJ7YgDFQAAAAAdAAAAABAK",

               });
            modelBuilder.Entity<Ingredient>().HasData(
                    new Ingredient { Id = 1, Name = "Tomato Sauce" },
                    new Ingredient { Id = 2, Name = "Mozzarella" }
                );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId=1, IngredientId=1 },
                new DishIngredient { DishId=1, IngredientId=2}
                );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> ingredients {  get; set; }
        public DbSet<DishIngredient> dishIngredients {  get; set; }
    }
}
