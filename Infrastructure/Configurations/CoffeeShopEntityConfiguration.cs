namespace Infrastructure.Configurations;

using Domain.Entities;

internal class CoffeeShopEntityConfiguration : IEntityTypeConfiguration<CoffeeShop>
{
    public void Configure(EntityTypeBuilder<CoffeeShop> builder)
    {
        builder
            .HasData(GenerateCoffeeShops());
    }


    private CoffeeShop[] GenerateCoffeeShops()
    {
        ICollection<CoffeeShop> coffeeShops = new HashSet<CoffeeShop>();

        CoffeeShop coffeeShop;
        coffeeShop = new CoffeeShop
        {
            Id = 1,
            Name = "FirstShop",
            OpeningHours = "AllTheTime",
            Address = "It's there"
        };
        coffeeShops.Add(coffeeShop);

        coffeeShop = new CoffeeShop
        {
            Id = 2,
            Name = "SecondShop",
            OpeningHours = "FullTime",
            Address = "It's somewhere"
        };
        coffeeShops.Add(coffeeShop);

        coffeeShop = new CoffeeShop
        {
            Id = 3,
            Name = "ThirdShop",
            OpeningHours = "PartTime",
            Address = "It's in the void"
        };
        coffeeShops.Add(coffeeShop);

        return coffeeShops.ToArray();
    }
}
}
