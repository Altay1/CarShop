using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Shop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Electro", Description = "Future is here!" });
            builder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Business", Description = "Extreme comfort and prestige" });
            builder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Off Road", Description = "Any where and anytime" });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/golfeorig.jpg",
                    Name = "Volkswagen Golf E",
                    ShortDescription = "Volkswagen Golf is a compact car.",
                    LongDescription = "The Golf blue-e-motion concept has a range of 150 km (93 mi). Volkswagen scheduled a field testing program with 500 units to begin in 2011. The first 10 units began field testing in Wolfsburg in May 2011. A second batch of 80 test cars began testing in June 2011 in Berlin, Hannover and Wolfsburg. In February 2012, the first e-Golf, as the production version was renamed, was delivered in Belmont, California. A total of 20 e-Golfs will be allocated to the U.S. field testing program.",
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/golfethumb.jpg"
                    
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsorig.jpg",
                    Name = "Tesla Model S",
                    ShortDescription = "Electric five-door liftback sedan.",
                    LongDescription = "Model S cars built after October 2016 have a feature called Autopilot, which is an advanced driver assistance system that allows the car to operate without assistance from the driver (but the driver must supervise continuously and take control if there is an issue). Autopilot 2.0 also includes Enhanced Summon, which allows the car to navigate through a parking lot to come to you, without anyone in the driver's seat. Sentry mode, available on cars built after August 2017, is a feature which senses and records suspicious activity around the car.",
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsthumb.jpg"
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/bmwi8thumb.jpg",
                    CategoryId = 1,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/bmwi8orig.jpg",
                    Name = "BMW I8",
                    ShortDescription = "Sports car developed by BMW.",
                    LongDescription = "The i8 is part of BMW's electric fleet \"Project i\" being marketed as a new sub-brand, BMW i. The 2015 model year BMW i8 has a 7.1 kWh lithium-ion battery pack that delivers an all-electric range of 37 km (23 mi) under the New European Driving Cycle. Under the United States Environmental Protection Agency cycle, the range in EV mode is 24 km (15 mi) with a small amount of gasoline consumption. Its design is heavily influenced by the BMW M1 Homage concept car, which in turn pays homage to BMW's last production mid-engined sports car prior to the i8: the BMW M1. BMW will cease the production of the BMW i8 in April 2020.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/sclassthumb.jpg",
                    CategoryId = 2,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/sclassorig.jpg",
                    Name = "Mercedes-Benz S-class",
                    ShortDescription = "The best of nothing!",
                    LongDescription = "The Mercedes-Benz S-Class, formerly known as Sonderklasse (German for \"special class\", abbreviated as \"S-Klasse\"), is a series of full-size luxury sedans and limousines produced by the German automaker Mercedes-Benz, a division of German company Daimler AG. The S-Class designation for top-of-the-line Mercedes-Benz models was officially introduced in 1972 with the W116, and has remained in use ever since.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/bmw7thumb.jpg",
                    CategoryId = 2,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/bmw7orig.jpg",
                    Name = "BMW 7 series",
                    ShortDescription = "Bayern power!",
                    LongDescription = "The BMW 7 Series is a full-size luxury sedan produced by the German automaker BMW since 1977. It is the successor to the BMW E3 \"New Six\" sedan and is currently in its sixth generation.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 6,
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/audia8thumb.jpg",
                    CategoryId = 2,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/audia8orig.jpg",
                    Name = "Audi A 8",
                    ShortDescription = "Luxury, sport, power!",
                    LongDescription = "The Audi A8 is a four-door, full-size, luxury sedan manufactured and marketed by the German automaker Audi since 1994. Succeeding the Audi V8, and now in its fourth generation, the A8 has been offered with both front- or permanent all-wheel drive—and in short- and long-wheelbase variants.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 7,
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/g63thumb.jpg",
                    CategoryId = 3,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/g63orig.jpg",
                    Name = "Mercedes-Benz G 63 AMG",
                    ShortDescription = "The First and the most Off Road vehicle",
                    LongDescription = "The Mercedes-Benz G-Class, sometimes called G-Wagen (short for Geländewagen, \"terrain vehicle\"), is a mid-size four-wheel drive luxury SUV manufactured by Magna Steyr (formerly Steyr-Daimler-Puch) in Austria and sold by Mercedes-Benz. In certain markets, it has been sold under the Puch name as Puch G.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 8,
                    ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/unnamedthumb.jpg",
                    CategoryId = 3,
                    ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/bmwx5orig.jpg",
                    Name = "BMW X5 M",
                    ShortDescription = "M Power",
                    LongDescription = "The X5 made its debut in 1999. It was BMW's first SUV and it also featured all-wheel drive and was available with either manual or automatic transmission. In 2006, the second generation X5 was launched, known internally as the E70. Introduced in the facelift version of the E53, the E70 also featured the torque-split capable xDrive all-wheel drive system mated to an automatic transmission. In 2009, the X5 M performance variant was released as a 2010 model.",
                });

            builder.Entity<Product>().HasData(
               new Product
               {
                   Id = 9,
                   ThumbImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/rsq8thumb.jpg",
                   CategoryId = 3,
                   ImageUrl = "https://raw.githubusercontent.com/Altay1/asdasd/master/rsq8orig.jpg",
                   Name = "Audi RS Q 8",
                   ShortDescription = "Fast!",
                   LongDescription = "The RS Q8 was unveiled at the 2019 LA Auto Show in November. The engine is shared with the RS 6 C8 and RS 7 4K8, a 4.0 litre Biturbo V8 mild-hybrid petrol unit with 591bhp and 800Nm (590 lb-ft) of torque. Like the SQ8, performance is sent through the 8-speed Tiptronic automatic gearbox to its quattro all-wheel drive system.",
               });
        }
    }
}
