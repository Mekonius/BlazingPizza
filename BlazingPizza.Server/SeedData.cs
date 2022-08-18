namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var toppings = new Topping[]
        {
            new Topping()
            {
                    Name = "Extra cheese",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "American bacon",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "British bacon",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Canadian bacon",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Tea and crumpets",
                    Price = 5.00m
            },
            new Topping()
            {
                    Name = "Fresh-baked scones",
                    Price = 4.50m,
            },
            new Topping()
            {
                    Name = "Bell peppers",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Onions",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Mushrooms",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Pepperoni",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Duck sausage",
                    Price = 3.20m,
            },
            new Topping()
            {
                    Name = "Venison meatballs",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "Served on a silver platter",
                    Price = 250.99m,
            },
            new Topping()
            {
                    Name = "Lobster on top",
                    Price = 64.50m,
            },
            new Topping()
            {
                    Name = "Sturgeon caviar",
                    Price = 101.75m,
            },
            new Topping()
            {
                    Name = "Artichoke hearts",
                    Price = 3.40m,
            },
            new Topping()
            {
                    Name = "Fresh tomatoes",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Basil",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Steak (medium-rare)",
                    Price = 8.50m,
            },
            new Topping()
            {
                    Name = "Blazing hot peppers",
                    Price = 4.20m,
            },
            new Topping()
            {
                    Name = "Buffalo chicken",
                    Price = 5.00m,
            },
            new Topping()
            {
                    Name = "Blue cheese",
                    Price = 2.50m,
            },
        };

        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                    Name = "Basic Cheese Pizza",
                    Description = "It's cheesy and delicious. Why wouldn't you want one?",
                    BasePrice = 59.99m,
                    ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 2,
                    Name = "The Baconatorizor",
                    Description = "It has EVERY kind of bacon",
                    BasePrice = 71.99m,
                    ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 3,
                    Name = "Classic pepperoni",
                    Description = "It's the pizza you grew up with, but Blazing hot!",
                    BasePrice = 60.50m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 4,
                    Name = "Buffalo chicken",
                    Description = "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up",
                    BasePrice = 82.75m,
                    ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 5,
                    Name = "Mushroom Lovers",
                    Description = "It has mushrooms. Isn't that obvious?",
                    BasePrice = 71.00m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 6,
                    Name = "The Brit",
                    Description = "When in London...",
                    BasePrice = 60.25m,
                    ImageUrl = "img/pizzas/brit.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 7,
                    Name = "Veggie Delight",
                    Description = "It's like salad, but on a pizza",
                    BasePrice = 81.50m,
                    ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 8,
                    Name = "Margherita",
                    Description = "Traditional Italian pizza with tomatoes and basil",
                    BasePrice = 78.99m,
                    ImageUrl = "img/pizzas/margherita.jpg",
            },
        };

        db.Toppings.AddRange(toppings);
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}