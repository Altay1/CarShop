﻿// <auto-generated />
using System;
using Car_Shop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Car_Shop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200406171235_fixthumnailnames")]
    partial class fixthumnailnames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Car_Shop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Electro",
                            Description = "Future is here!"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Business",
                            Description = "Extreme comfort and prestige"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Off Road",
                            Description = "Any where and anytime"
                        });
                });

            modelBuilder.Entity("Car_Shop.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Car_Shop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("NameOnCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Car_Shop.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Car_Shop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImageUrl = "~/Images/thumbnail/golfe.jpg",
                            LongDescription = "The Golf blue-e-motion concept has a range of 150 km (93 mi). Volkswagen scheduled a field testing program with 500 units to begin in 2011. The first 10 units began field testing in Wolfsburg in May 2011. A second batch of 80 test cars began testing in June 2011 in Berlin, Hannover and Wolfsburg. In February 2012, the first e-Golf, as the production version was renamed, was delivered in Belmont, California. A total of 20 e-Golfs will be allocated to the U.S. field testing program.",
                            Name = "Volkswagen Golf E",
                            ShortDescription = "Volkswagen Golf is a compact car produced by the German automotive manufacturer Volkswagen since 1974",
                            ThumbImageUrl = "https://s111myt.storage.yandex.net/rdisk/609b0045de6e043e2754a26df019010838ca1990bf1a75bfb09f2f3c00a779dc/5e860b36/yQXUW-T4bM2L-nrKhsj_POUja5qNr4tS3f33KJ51UBbyULqgG5hILLSEapPg8cOm2VUJ8n4M9C3XW8VbY-w_Tg==?uid=83539494&filename=golf%20e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=23203&hid=dbea2f1f0b7c020ff0157b0ebea79ad5&media_type=image&tknv=v2&etag=3b0246451cd5e2c711bac5562b73d6f9&rtoken=dAgZxatOposg&force_default=yes&ycrid=na-4b0f24f75aa2e1d3860cfc2a2f7cf273-downloader9h&ts=5a250d890b980&s=654e63de6789e41ca85af4d7aaaa7d91776c32e68d9ba0871a0e8e245e4c543d&pb=U2FsdGVkX18CFF_rLBc_nbMGK-E4gus7WpFZCcZhcbf_KdN-RdpnOvzRNZR5CSrQGqd1uQzn6s2zUKd8tdYAMdFx1mCETpDKDrOsBnR1_PI"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImageUrl = "~/Images/thumbnail/teslamodels.jpg",
                            LongDescription = "Model S cars built after October 2016 have a feature called Autopilot, which is an advanced driver assistance system that allows the car to operate without assistance from the driver (but the driver must supervise continuously and take control if there is an issue). Autopilot 2.0 also includes Enhanced Summon, which allows the car to navigate through a parking lot to come to you, without anyone in the driver's seat. Sentry mode, available on cars built after August 2017, is a feature which senses and records suspicious activity around the car.",
                            Name = "Tesla Model S",
                            ShortDescription = "The Tesla Model S is an all-electric five-door liftback sedan, produced by Tesla, Inc.",
                            ThumbImageUrl = "https://s229iva.storage.yandex.net/rdisk/28263d973ea4842a5a05e3dbe337bd2e275c961e7307b8479fd567c888850f50/5e860b65/yQXUW-T4bM2L-nrKhsj_PL7bjdsxWzsNZiXSlipEancPdpjLTX0PxWgjFh3mbfXe6_CdthgyRuQS_fw7mvJwHQ==?uid=83539494&filename=tesla%20model%20s.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=15408&hid=cbf25c90edee8e8c45c18ed674a025f2&media_type=image&tknv=v2&etag=62631519bc645930521da9be7ed4d475&rtoken=dA5HbqsE7a4O&force_default=yes&ycrid=na-b74fbd6000abb266f9f3ef9f8c62416b-downloader9h&ts=5a250db5de340&s=65e34ee28217fb2ac0e4dce16f3b3b8b61d351421b2922dfde8d951bf70454f6&pb=U2FsdGVkX18a3xi4qmCbO30hgCr-eRdd4riYzh3zucEfL1r8rQ3Lk0KPVQU9cyKeqq3l0zROD_9En863MT87nKfOQgPiUfx-u9P0MADQaLk"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ImageUrl = "https://s51myt.storage.yandex.net/rdisk/be9ac85a4d97bcf91e547e3ab89d7509ac27646b5ebaba1ca184725451f0b2cb/5e8602cb/yQXUW-T4bM2L-nrKhsj_PPnuauj36nS79J79TvetvpXdK8XuMVWxvwx-Ly1Ao1ntyZK_j8iuCFb5eNHm2ZXYNw==?uid=83539494&filename=bmw%20i8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=158687&hid=ff01adb9eb0fe1c877989c4261ce1a22&media_type=image&tknv=v2&etag=f4afdbfa0f0a039f8fc2f16031e2950b&rtoken=AuK3azHmK75T&force_default=yes&ycrid=na-d0112279304e2a95c388c980339ceb88-downloader1h&ts=5a250581e08c0&s=347fbc7d3faab008d645e199fb5be40d03baee1b5d07fb26f2eb63198c856905&pb=U2FsdGVkX18S-NV-vM3oXkHmkrwvC0FkxhfXc1uvPWph5qTh22eJfEcFS8E0dnkCQgAQ0WsmBLFX0h9oNpBkj0JNS219XfjxxF4_9s3JbIw",
                            LongDescription = "The i8 is part of BMW's electric fleet \"Project i\" being marketed as a new sub-brand, BMW i. The 2015 model year BMW i8 has a 7.1 kWh lithium-ion battery pack that delivers an all-electric range of 37 km (23 mi) under the New European Driving Cycle. Under the United States Environmental Protection Agency cycle, the range in EV mode is 24 km (15 mi) with a small amount of gasoline consumption. Its design is heavily influenced by the BMW M1 Homage concept car, which in turn pays homage to BMW's last production mid-engined sports car prior to the i8: the BMW M1. BMW will cease the production of the BMW i8 in April 2020.",
                            Name = "BMW I8",
                            ShortDescription = "The BMW i8 is a plug-in hybrid sports car developed by BMW.",
                            ThumbImageUrl = "~/Images/thumbnail/bmwi8.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ImageUrl = "https://s132iva.storage.yandex.net/rdisk/e89669b4eace6971a019453c6d4bb0a3d24a6c77e980a99f5757d1925e219ad1/5e8603ae/0Y13mknKtqE-NQSyRRPUROnN-Km2er7hJLb2UsmfEH2J5jx8J4ARonW4OtvNL2Dpi7f_c2e1538UwDXYCboQ1A==?uid=83539494&filename=mercedes-benz-s-klasse-front1-mini.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=321198&hid=3a1586b4c65f8edd1d1922c7d504b8ac&media_type=image&tknv=v2&etag=806615bbda4faea6b1eb7896f41af8ed&rtoken=JF4phtJpNJZm&force_default=yes&ycrid=na-7e3f5b74716afe735359e66b09668658-downloader12f&ts=5a25065a5c780&s=6909575e592a1ec6bf5ffcd4339658cb5269cb602b69c8c467f979dae8fe83ae&pb=U2FsdGVkX1895NJDcfflHlN39pga2Q81WZoSqsRW9xRFocfqTz8Bf7pGGWXiqP7W2roCP2NVITwwD0slLZRgIxOWNzsjTYo4X8sbhNNxZ5M",
                            LongDescription = "The Mercedes-Benz S-Class, formerly known as Sonderklasse (German for \"special class\", abbreviated as \"S-Klasse\"), is a series of full-size luxury sedans and limousines produced by the German automaker Mercedes-Benz, a division of German company Daimler AG. The S-Class designation for top-of-the-line Mercedes-Benz models was officially introduced in 1972 with the W116, and has remained in use ever since.",
                            Name = "Mercedes-Benz S-class",
                            ShortDescription = "The best of nothing!",
                            ThumbImageUrl = "~/Images/thumbnail/sclass.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ImageUrl = "https://disk.yandex.kz/client/disk/Car%20shop%20files/Photos?idApp=client&dialog=slider&idDialog=%2Fdisk%2FCar%20shop%20files%2FPhotos%2Fbmw%207.jpg",
                            LongDescription = "The BMW 7 Series is a full-size luxury sedan produced by the German automaker BMW since 1977. It is the successor to the BMW E3 \"New Six\" sedan and is currently in its sixth generation.",
                            Name = "BMW 7 series",
                            ShortDescription = "Bayern power!",
                            ThumbImageUrl = "~/Images/thumbnail/bmw7.jpg"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            ImageUrl = "https://s228sas.storage.yandex.net/rdisk/fa5632cd06e124631d314ded7bdb7b7b3c053bb3a6821c2c8d411cc295078286/5e8604f0/OlpYcOXuxNT1pMrMnKPzGEam_L_6GBQsFEJ2oA2GxtSaM_FytNCNlGcDqYUxUtS3gl3Ppx-GaXuZbQovYbVg1w==?uid=83539494&filename=audi-a8-l-60-tfsi-e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=166829&hid=c9f09260797092f985512e406a39ffb7&media_type=image&tknv=v2&etag=8d0dd18dc0f81c6ceec9d2cb61b96982&rtoken=dE4FeKVccVdt&force_default=yes&ycrid=na-c04d78a2382006932ff07eea2a39cf35-downloader11h&ts=5a25078d71c00&s=fa71182a21eb921dcd265fa235e1dc5a75f393c1577928106a31bbbc07afd0a4&pb=U2FsdGVkX1_X5npcHQNn3D1B5MxAaiZx7beabsi2myYIDdNI2_UoO_eqD-HwfnAZ_cIL-F_HCYFkkmlvX09ypNoGjHdKJ69t9sgYR6v90tA",
                            LongDescription = "The Audi A8 is a four-door, full-size, luxury sedan manufactured and marketed by the German automaker Audi since 1994. Succeeding the Audi V8, and now in its fourth generation, the A8 has been offered with both front- or permanent all-wheel drive—and in short- and long-wheelbase variants.",
                            Name = "Audi A 8",
                            ShortDescription = "Luxury, sport, power!",
                            ThumbImageUrl = "~/Images/thumbnail/audia8.jpg"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            ImageUrl = "https://s12iva.storage.yandex.net/rdisk/50ee1b1fff7b279fc7a930a121714916d9c59c6adc0fc0b14bbc24e3a37106c8/5e860590/yQXUW-T4bM2L-nrKhsj_PLMs2DZPP8r7IQnnzNHQFGr24iXsVOPzhcuq4WqLTbD4WOS3hcNG5PV3t-F3_yhRtw==?uid=83539494&filename=g63.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=73071&hid=48ba1377109fbc57d1e58c5af405b9fc&media_type=image&tknv=v2&etag=f5b1529a851f10cfcd3ddbf3a65e02a6&rtoken=P4RWw1zrwNqd&force_default=yes&ycrid=na-0d2ddbb25a9932fe78d5047fa04d1b44-downloader4e&ts=5a25082608400&s=3cdb124e78b7a8271e40c98718406f8b0042106782d2019cef753d34db6b99bf&pb=U2FsdGVkX1-cuNONxKFUYyZ4hvMcOvQ0AIiA58XNmDiiCJDgGToWng4szaaFdkYsstjT6ERmyi3WWREA9artPR92GBVV8UEDEXIWrkqrD2U",
                            LongDescription = "The Mercedes-Benz G-Class, sometimes called G-Wagen (short for Geländewagen, \"terrain vehicle\"), is a mid-size four-wheel drive luxury SUV manufactured by Magna Steyr (formerly Steyr-Daimler-Puch) in Austria and sold by Mercedes-Benz. In certain markets, it has been sold under the Puch name as Puch G.",
                            Name = "Mercedes-Benz G 63 AMG",
                            ShortDescription = "The First and the most Off Road vehicle",
                            ThumbImageUrl = "~/Images/thumbnail/g63.jpg"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            ImageUrl = "https://s559sas.storage.yandex.net/rdisk/2c9eb9d732bf37224ad40162568cb12f4a80966aba28eff445b39610463b1722/5e860648/yQXUW-T4bM2L-nrKhsj_PJP2p9pBW35FUZ8dzn2lndy6WTbKhGFxj4IE-lU8mNZJVjsNk1rGKsU_O6hcYb2m7g==?uid=83539494&filename=unnamed.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=91363&hid=d54669c15b7b502b319e4d465bd43004&media_type=image&tknv=v2&etag=bbf29aae6d386301b332db13502f6be2&rtoken=PH5eZCjMiTf7&force_default=yes&ycrid=na-0800836365d09375094648e11092e5bb-downloader4h&ts=5a2508d582200&s=25162861e35f1aab15e0c20f82051d8314bab9fac19afbb6a34b24995701dcde&pb=U2FsdGVkX19z6WJ1_8jy4Cs4IcQfAC4QJp6f8tcLtVaL-Z-34QyTHSbtzg6bwVHYeRjcSl8vWFpxRKsKBBzGBdIgOGTODAzIHPVil1S7P40",
                            LongDescription = "The X5 made its debut in 1999. It was BMW's first SUV and it also featured all-wheel drive and was available with either manual or automatic transmission. In 2006, the second generation X5 was launched, known internally as the E70. Introduced in the facelift version of the E53, the E70 also featured the torque-split capable xDrive all-wheel drive system mated to an automatic transmission. In 2009, the X5 M performance variant was released as a 2010 model.",
                            Name = "BMW X5 M",
                            ShortDescription = "M Power",
                            ThumbImageUrl = "~/Images/thumbnail/unnamed.jpg"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            ImageUrl = "https://s229iva.storage.yandex.net/rdisk/95682c502ddb26cda7b912e825b3b19aafbb72be7a266ac2979838a4ab65e74d/5e8606bb/yQXUW-T4bM2L-nrKhsj_PPc0YIlF4sZYWJymozEdzMeHDgLUuPdb-Q91REweDlyTQ4MeyDgnfK0SMJqZHNOEbw==?uid=83539494&filename=rsq8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=76531&hid=ae0c8f6ccc9536d7787e4c725f826f8c&media_type=image&tknv=v2&etag=2187c96fc7d0427d8a270d45ef3f63d9&rtoken=rAlgJ2WZXkVd&force_default=yes&ycrid=na-4bbe789c45235be883690db8eea7cc8d-downloader10e&ts=5a2509432e4c0&s=46b08469c6f3066f198e2e3e8032916093fe175a3c73c38898cfc31d575ef04a&pb=U2FsdGVkX1_VmAH9vyEPCF5CDmBW2HTvcws7nZ52adKGH7AwIq5pI11GjL_qeGW3xYdr-b3ltWzeLab4VQ8ff7HaY6xNEESQ70OXnEszOeI",
                            LongDescription = "The RS Q8 was unveiled at the 2019 LA Auto Show in November. The engine is shared with the RS 6 C8 and RS 7 4K8, a 4.0 litre Biturbo V8 mild-hybrid petrol unit with 591bhp and 800Nm (590 lb-ft) of torque. Like the SQ8, performance is sent through the 8-speed Tiptronic automatic gearbox to its quattro all-wheel drive system.",
                            Name = "Audi RS Q 8",
                            ShortDescription = "Fast!",
                            ThumbImageUrl = "~/Images/thumbnail/rsq8.jpg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Car_Shop.Models.Order", b =>
                {
                    b.HasOne("Car_Shop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Shop.Models.OrderDetail", b =>
                {
                    b.HasOne("Car_Shop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Car_Shop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Car_Shop.Models.Product", b =>
                {
                    b.HasOne("Car_Shop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}