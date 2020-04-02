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
                    ImageUrl = "https://1.downloader.disk.yandex.kz/disk/15f9706f1a1ca0688ea86385cfa863e248bb18d15d06bba890504ed48421bb93/5e85ff6b/dwsY6Kws-bBmkYfopIqSkamr5hzRwyHSYjfFPcxWjbflT8FqKytosrL8rKyl4KqJq_J6bpmRyOJonT3VoXnDag%3D%3D?uid=83539494&filename=golf%20e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=143921&hid=15b5ec12348111e5cd412e99ae6ec49a&media_type=image&tknv=v2&etag=8dacdf30eff744a266c3919ef758ba40",
                    Name = "Volkswagen Golf E",
                    ShortDescription = "Volkswagen Golf is a compact car produced by the German automotive manufacturer Volkswagen since 1974",
                    LongDescription = "The Golf blue-e-motion concept has a range of 150 km (93 mi). Volkswagen scheduled a field testing program with 500 units to begin in 2011. The first 10 units began field testing in Wolfsburg in May 2011. A second batch of 80 test cars began testing in June 2011 in Berlin, Hannover and Wolfsburg. In February 2012, the first e-Golf, as the production version was renamed, was delivered in Belmont, California. A total of 20 e-Golfs will be allocated to the U.S. field testing program.",
                    ThumbImageUrl = "https://s111myt.storage.yandex.net/rdisk/609b0045de6e043e2754a26df019010838ca1990bf1a75bfb09f2f3c00a779dc/5e860b36/yQXUW-T4bM2L-nrKhsj_POUja5qNr4tS3f33KJ51UBbyULqgG5hILLSEapPg8cOm2VUJ8n4M9C3XW8VbY-w_Tg==?uid=83539494&filename=golf%20e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=23203&hid=dbea2f1f0b7c020ff0157b0ebea79ad5&media_type=image&tknv=v2&etag=3b0246451cd5e2c711bac5562b73d6f9&rtoken=dAgZxatOposg&force_default=yes&ycrid=na-4b0f24f75aa2e1d3860cfc2a2f7cf273-downloader9h&ts=5a250d890b980&s=654e63de6789e41ca85af4d7aaaa7d91776c32e68d9ba0871a0e8e245e4c543d&pb=U2FsdGVkX18CFF_rLBc_nbMGK-E4gus7WpFZCcZhcbf_KdN-RdpnOvzRNZR5CSrQGqd1uQzn6s2zUKd8tdYAMdFx1mCETpDKDrOsBnR1_PI"
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    ImageUrl = "https://s173vla.storage.yandex.net/rdisk/f499b535a265c0c64a232aa2041dabb902f817c071e0dba1a3632cc830b4185d/5e8600e2/ypoLQQd6SEXjlgH6-LDMd1ffvERwel4jWybJbqwyCXFU8HgkoGIcgVRnSuhPjJxuorkGj-6TPNCxD_Wca7YrfQ==?uid=83539494&filename=tesla%20model%20s.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=75508&hid=e0e00095069c184d0da2140a880d8043&media_type=image&tknv=v2&etag=bdb1a629ae189c8d2c23206b2c4f1314&rtoken=xZpcnTjfGpZn&force_default=yes&ycrid=na-8422a06888b27a0528680792a42b8d76-downloader24h&ts=5a2503af87c80&s=063bc46ebd34082b5b2a8bfb240dda4287ff1b715e8fe981443dac122155f0f1&pb=U2FsdGVkX18mV3gUF8brW-NUNevLnUmwzhbwjrYfKR3ZsrbgDMCcQhGF2I4AGl2VxNlEhdRcepLNvEgMXCBEeZqjyTVWKuvIcCkjU56zl0Q",
                    Name = "Tesla Model S",
                    ShortDescription = "The Tesla Model S is an all-electric five-door liftback sedan, produced by Tesla, Inc.",
                    LongDescription = "Model S cars built after October 2016 have a feature called Autopilot, which is an advanced driver assistance system that allows the car to operate without assistance from the driver (but the driver must supervise continuously and take control if there is an issue). Autopilot 2.0 also includes Enhanced Summon, which allows the car to navigate through a parking lot to come to you, without anyone in the driver's seat. Sentry mode, available on cars built after August 2017, is a feature which senses and records suspicious activity around the car.",
                    ThumbImageUrl = "https://s229iva.storage.yandex.net/rdisk/28263d973ea4842a5a05e3dbe337bd2e275c961e7307b8479fd567c888850f50/5e860b65/yQXUW-T4bM2L-nrKhsj_PL7bjdsxWzsNZiXSlipEancPdpjLTX0PxWgjFh3mbfXe6_CdthgyRuQS_fw7mvJwHQ==?uid=83539494&filename=tesla%20model%20s.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=15408&hid=cbf25c90edee8e8c45c18ed674a025f2&media_type=image&tknv=v2&etag=62631519bc645930521da9be7ed4d475&rtoken=dA5HbqsE7a4O&force_default=yes&ycrid=na-b74fbd6000abb266f9f3ef9f8c62416b-downloader9h&ts=5a250db5de340&s=65e34ee28217fb2ac0e4dce16f3b3b8b61d351421b2922dfde8d951bf70454f6&pb=U2FsdGVkX18a3xi4qmCbO30hgCr-eRdd4riYzh3zucEfL1r8rQ3Lk0KPVQU9cyKeqq3l0zROD_9En863MT87nKfOQgPiUfx-u9P0MADQaLk"
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 3,
                    ThumbImageUrl = "https://s170iva.storage.yandex.net/rdisk/88a050d8e081ba0847606b3e00826f91100541c4bf19ac12b4fb16d9abe7558f/5e860b86/yQXUW-T4bM2L-nrKhsj_PJm-J1BnzI7wAyNpwbXuoHgLiO0pQq7p4Bj9NvG0_oVJ0SVKgHrlixsmmWbXjiW-qQ==?uid=83539494&filename=bmw%20i8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=14737&hid=94197ebf3241e5bb15b856ef2df5bea9&media_type=image&tknv=v2&etag=4f15d312c515286bfe99e2aa376e169b&rtoken=NMxW0duaIvb6&force_default=yes&ycrid=na-b29bcf6c947420a473475c098814218c-downloader3e&ts=5a250dd556d80&s=417b26e36866c6d572dd6583f07776057faa46871f56d6ce9b37cc7e42cef498&pb=U2FsdGVkX1-39jcg7n0GT0ilJdEwkWxO0oA-MFAl5BWr-bm7jYwWp4bK3O-MAZQIqpF03_uir-lO-6MPeQSrdmyMk67fRU7xR_tEX1DUCwc",
                    CategoryId = 1,
                    ImageUrl = "https://s51myt.storage.yandex.net/rdisk/be9ac85a4d97bcf91e547e3ab89d7509ac27646b5ebaba1ca184725451f0b2cb/5e8602cb/yQXUW-T4bM2L-nrKhsj_PPnuauj36nS79J79TvetvpXdK8XuMVWxvwx-Ly1Ao1ntyZK_j8iuCFb5eNHm2ZXYNw==?uid=83539494&filename=bmw%20i8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=158687&hid=ff01adb9eb0fe1c877989c4261ce1a22&media_type=image&tknv=v2&etag=f4afdbfa0f0a039f8fc2f16031e2950b&rtoken=AuK3azHmK75T&force_default=yes&ycrid=na-d0112279304e2a95c388c980339ceb88-downloader1h&ts=5a250581e08c0&s=347fbc7d3faab008d645e199fb5be40d03baee1b5d07fb26f2eb63198c856905&pb=U2FsdGVkX18S-NV-vM3oXkHmkrwvC0FkxhfXc1uvPWph5qTh22eJfEcFS8E0dnkCQgAQ0WsmBLFX0h9oNpBkj0JNS219XfjxxF4_9s3JbIw",
                    Name = "BMW I8",
                    ShortDescription = "The BMW i8 is a plug-in hybrid sports car developed by BMW.",
                    LongDescription = "The i8 is part of BMW's electric fleet \"Project i\" being marketed as a new sub-brand, BMW i. The 2015 model year BMW i8 has a 7.1 kWh lithium-ion battery pack that delivers an all-electric range of 37 km (23 mi) under the New European Driving Cycle. Under the United States Environmental Protection Agency cycle, the range in EV mode is 24 km (15 mi) with a small amount of gasoline consumption. Its design is heavily influenced by the BMW M1 Homage concept car, which in turn pays homage to BMW's last production mid-engined sports car prior to the i8: the BMW M1. BMW will cease the production of the BMW i8 in April 2020.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    ThumbImageUrl = "https://s97iva.storage.yandex.net/rdisk/41215347a6fe646f30c12223a9268acd9f4461e81f1962d7464ddd6c21d24b48/5e860bbc/yQXUW-T4bM2L-nrKhsj_PGGp6h8qCbaBhC5N3HwMOj0mH8HnnkwJ0H0RjUPsETk5woXnlU8EagAs1qjBX_tsDA==?uid=83539494&filename=mercedes-benz-s-klasse-front1-mini.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=21026&hid=7c147e1e9b75cabdc73e39ded645a233&media_type=image&tknv=v2&etag=c013afc50577a2cbeee8364dbb5f995e&rtoken=KSDx0DALF6dy&force_default=yes&ycrid=na-f6713b6278c304aac1ecb7eb98bc7b50-downloader9e&ts=5a250e08d6700&s=7a843ee6538acf7cb9a422a7dba253d2389af287e5661a5dfe02346955616817&pb=U2FsdGVkX18Og-2ggHVai4zIbZFJq3OT7xOGwq4WDaR8ft1oZkvkND056EY8A3u3BzCtA1K3vWch-VI3IgXzqQe7X2zJWytHXEL_FYWiz_I",
                    CategoryId = 2,
                    ImageUrl = "https://s132iva.storage.yandex.net/rdisk/e89669b4eace6971a019453c6d4bb0a3d24a6c77e980a99f5757d1925e219ad1/5e8603ae/0Y13mknKtqE-NQSyRRPUROnN-Km2er7hJLb2UsmfEH2J5jx8J4ARonW4OtvNL2Dpi7f_c2e1538UwDXYCboQ1A==?uid=83539494&filename=mercedes-benz-s-klasse-front1-mini.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=321198&hid=3a1586b4c65f8edd1d1922c7d504b8ac&media_type=image&tknv=v2&etag=806615bbda4faea6b1eb7896f41af8ed&rtoken=JF4phtJpNJZm&force_default=yes&ycrid=na-7e3f5b74716afe735359e66b09668658-downloader12f&ts=5a25065a5c780&s=6909575e592a1ec6bf5ffcd4339658cb5269cb602b69c8c467f979dae8fe83ae&pb=U2FsdGVkX1895NJDcfflHlN39pga2Q81WZoSqsRW9xRFocfqTz8Bf7pGGWXiqP7W2roCP2NVITwwD0slLZRgIxOWNzsjTYo4X8sbhNNxZ5M",
                    Name = "Mercedes-Benz S-class",
                    ShortDescription = "The best of nothing!",
                    LongDescription = "The Mercedes-Benz S-Class, formerly known as Sonderklasse (German for \"special class\", abbreviated as \"S-Klasse\"), is a series of full-size luxury sedans and limousines produced by the German automaker Mercedes-Benz, a division of German company Daimler AG. The S-Class designation for top-of-the-line Mercedes-Benz models was officially introduced in 1972 with the W116, and has remained in use ever since.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 5,
                    ThumbImageUrl = "https://s06man.storage.yandex.net/rdisk/0f4c5ba16dd337192cb19793ae735ee7d0207b96e3113122b75a62e712153041/5e860bda/yQXUW-T4bM2L-nrKhsj_PB-dLPekFSvk79EDPz2XVyOV9ISsDq1sSdzSLEGPibA7m7yGT5Wzj1Z17nYVtN6PBA==?uid=83539494&filename=bmw%207.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=12316&hid=85500e5b8f72cb9dacddc452a6c47ab9&media_type=image&tknv=v2&etag=5248dc59f75fc06a6a53a3befd9f0864&rtoken=vDIi0Yoxk7cY&force_default=yes&ycrid=na-27b2a348b2957609ddc3258ea574396a-downloader13h&ts=5a250e2572a80&s=fdcfa765c73bfcc976868964d172ee1bc0bdd19db3342b310508d1b8a276b3de&pb=U2FsdGVkX1-R51NQAqgYL7RptBfMlcyfQiNi_w1W5GsfQvs4SnzoECA88g7fgW66xhcSvhDlox-PoL8__2-2W7c27FMyTYxE2XmKDAMg7xQ",
                    CategoryId = 2,
                    ImageUrl = "https://disk.yandex.kz/client/disk/Car%20shop%20files/Photos?idApp=client&dialog=slider&idDialog=%2Fdisk%2FCar%20shop%20files%2FPhotos%2Fbmw%207.jpg",
                    Name = "BMW 7 series",
                    ShortDescription = "Bayern power!",
                    LongDescription = "The BMW 7 Series is a full-size luxury sedan produced by the German automaker BMW since 1977. It is the successor to the BMW E3 \"New Six\" sedan and is currently in its sixth generation.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 6,
                    ThumbImageUrl = "https://s20vla.storage.yandex.net/rdisk/f9b660372ca4bf2b37d98441feef119e0186d7f5af3fd119f330bfe957167f97/5e860bf0/yQXUW-T4bM2L-nrKhsj_PKkqiLjDu59_CAa_Wl0BmPxJb4_ntnrOa2XQ2YsDUMCZ8iCzZf7cPONLJSLr7p8Rew==?uid=83539494&filename=audi-a8-l-60-tfsi-e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=20976&hid=51d355943e656ec307318eb28f52b4b0&media_type=image&tknv=v2&etag=06894d3288cfe2b365c66a5dee9f1b11&rtoken=yMTQvJY6MWXk&force_default=yes&ycrid=na-52be96980820cc4898563b33ef8aaf81-downloader13h&ts=5a250e3a6dc00&s=ad8f3b0982413c6e604ca01db4f1d6af4117d5fb2637e99c49893ed56c472a2f&pb=U2FsdGVkX1-9FUt6zRjZy1248HDNpUOlYdZ6F6Q3oGtyR8l3NCkkD3O2QJR6-tBQARxG1DnvhP9bW9gE2hMrPP4rSXJ8pkfijJX2qywXWj0",
                    CategoryId = 2,
                    ImageUrl = "https://s228sas.storage.yandex.net/rdisk/fa5632cd06e124631d314ded7bdb7b7b3c053bb3a6821c2c8d411cc295078286/5e8604f0/OlpYcOXuxNT1pMrMnKPzGEam_L_6GBQsFEJ2oA2GxtSaM_FytNCNlGcDqYUxUtS3gl3Ppx-GaXuZbQovYbVg1w==?uid=83539494&filename=audi-a8-l-60-tfsi-e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=166829&hid=c9f09260797092f985512e406a39ffb7&media_type=image&tknv=v2&etag=8d0dd18dc0f81c6ceec9d2cb61b96982&rtoken=dE4FeKVccVdt&force_default=yes&ycrid=na-c04d78a2382006932ff07eea2a39cf35-downloader11h&ts=5a25078d71c00&s=fa71182a21eb921dcd265fa235e1dc5a75f393c1577928106a31bbbc07afd0a4&pb=U2FsdGVkX1_X5npcHQNn3D1B5MxAaiZx7beabsi2myYIDdNI2_UoO_eqD-HwfnAZ_cIL-F_HCYFkkmlvX09ypNoGjHdKJ69t9sgYR6v90tA",
                    Name = "Audi A 8",
                    ShortDescription = "Luxury, sport, power!",
                    LongDescription = "The Audi A8 is a four-door, full-size, luxury sedan manufactured and marketed by the German automaker Audi since 1994. Succeeding the Audi V8, and now in its fourth generation, the A8 has been offered with both front- or permanent all-wheel drive—and in short- and long-wheelbase variants.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 7,
                    ThumbImageUrl = "https://s235vla.storage.yandex.net/rdisk/31868ce61722a5c5bde5c2659840ecd2c3df862b439768eb0c55e717fe3b2144/5e860c0e/yQXUW-T4bM2L-nrKhsj_PCVWbmWzb9Jra52XHpHMobyktgpH5DZvrTeTbODTR8ryxrc-DYOFNf3IPNXuG0ug6A==?uid=83539494&filename=g63.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=16930&hid=f6258e8a35ed62ba893e4569a8e5c901&media_type=image&tknv=v2&etag=eaed4ff9e06d086bb2add24eb4fc5a44&rtoken=BPLclenhMlmR&force_default=yes&ycrid=na-fe1c707fb2de8ff0103bbfe2c28b3e37-downloader13h&ts=5a250e5709f80&s=97a2c54cccb6e9d6d428f645f288452d9fbbabe5c1ab7ca9370866e61abcd3f2&pb=U2FsdGVkX1-oQz0c8-o_v8nNMirAkGyIbdNpCYXtvV6Rv4XRgnE0Ojtg_M20KR8jZ5GColZcb5oGF4zMJuIXN-OameAIC4ejSN9SoNEFFLw",
                    CategoryId = 3,
                    ImageUrl = "https://s12iva.storage.yandex.net/rdisk/50ee1b1fff7b279fc7a930a121714916d9c59c6adc0fc0b14bbc24e3a37106c8/5e860590/yQXUW-T4bM2L-nrKhsj_PLMs2DZPP8r7IQnnzNHQFGr24iXsVOPzhcuq4WqLTbD4WOS3hcNG5PV3t-F3_yhRtw==?uid=83539494&filename=g63.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=73071&hid=48ba1377109fbc57d1e58c5af405b9fc&media_type=image&tknv=v2&etag=f5b1529a851f10cfcd3ddbf3a65e02a6&rtoken=P4RWw1zrwNqd&force_default=yes&ycrid=na-0d2ddbb25a9932fe78d5047fa04d1b44-downloader4e&ts=5a25082608400&s=3cdb124e78b7a8271e40c98718406f8b0042106782d2019cef753d34db6b99bf&pb=U2FsdGVkX1-cuNONxKFUYyZ4hvMcOvQ0AIiA58XNmDiiCJDgGToWng4szaaFdkYsstjT6ERmyi3WWREA9artPR92GBVV8UEDEXIWrkqrD2U",
                    Name = "Mercedes-Benz G 63 AMG",
                    ShortDescription = "The First and the most Off Road vehicle",
                    LongDescription = "The Mercedes-Benz G-Class, sometimes called G-Wagen (short for Geländewagen, \"terrain vehicle\"), is a mid-size four-wheel drive luxury SUV manufactured by Magna Steyr (formerly Steyr-Daimler-Puch) in Austria and sold by Mercedes-Benz. In certain markets, it has been sold under the Puch name as Puch G.",
                });

            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 8,
                    ThumbImageUrl = "https://s286iva.storage.yandex.net/rdisk/b0a9afad3335188a2c5340df15c955e7076d78e391962a7192204cf6c5e831fb/5e860c31/yQXUW-T4bM2L-nrKhsj_PFl_h7XKuHqXq7GrG1uos0yuADCZvewB9j7kqT4e0RPpx9pxIu1Ephtr4m767Ihjiw==?uid=83539494&filename=unnamed.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=31656&hid=b6488c30f9c0f2df95c8338ccb276233&media_type=image&tknv=v2&etag=d50e5dbc761771c45103e55c95d3fadf&rtoken=NmnuhHpQRKH8&force_default=yes&ycrid=na-c856272cb5b101632e325934eb683eb5-downloader8f&ts=5a250e786ae40&s=28ee83d0778b8a34d6d3368908c4966350168cc8473bfca599888bf3bb82f934&pb=U2FsdGVkX1-nAtJdOYFVxFlQFgGVx-7GjokFL8PP793b3wq-Ci0NzWfAhldPvGd0xeU2UOVuaesFqgmkI-G7_7oF3mePr5jXTCYavncy_rc",
                    CategoryId = 3,
                    ImageUrl = "https://s559sas.storage.yandex.net/rdisk/2c9eb9d732bf37224ad40162568cb12f4a80966aba28eff445b39610463b1722/5e860648/yQXUW-T4bM2L-nrKhsj_PJP2p9pBW35FUZ8dzn2lndy6WTbKhGFxj4IE-lU8mNZJVjsNk1rGKsU_O6hcYb2m7g==?uid=83539494&filename=unnamed.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=91363&hid=d54669c15b7b502b319e4d465bd43004&media_type=image&tknv=v2&etag=bbf29aae6d386301b332db13502f6be2&rtoken=PH5eZCjMiTf7&force_default=yes&ycrid=na-0800836365d09375094648e11092e5bb-downloader4h&ts=5a2508d582200&s=25162861e35f1aab15e0c20f82051d8314bab9fac19afbb6a34b24995701dcde&pb=U2FsdGVkX19z6WJ1_8jy4Cs4IcQfAC4QJp6f8tcLtVaL-Z-34QyTHSbtzg6bwVHYeRjcSl8vWFpxRKsKBBzGBdIgOGTODAzIHPVil1S7P40",
                    Name = "BMW X5 M",
                    ShortDescription = "M Power",
                    LongDescription = "The X5 made its debut in 1999. It was BMW's first SUV and it also featured all-wheel drive and was available with either manual or automatic transmission. In 2006, the second generation X5 was launched, known internally as the E70. Introduced in the facelift version of the E53, the E70 also featured the torque-split capable xDrive all-wheel drive system mated to an automatic transmission. In 2009, the X5 M performance variant was released as a 2010 model.",
                });

            builder.Entity<Product>().HasData(
               new Product
               {
                   Id = 9,
                   ThumbImageUrl = "https://s139myt.storage.yandex.net/rdisk/8f2b83903cdc7422013158d1faf6febd1758e4879c739cce2df3f3913f6b3640/5e860c49/yQXUW-T4bM2L-nrKhsj_PLmeLqI1c8WVjv7uIQBXxd7hR864kujYhnJYBufv_o7g2VncEiRtBTLAmw6Itswi1A==?uid=83539494&filename=rsq8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=19222&hid=cb0222ce652a7b2686a93802a015c1ee&media_type=image&tknv=v2&etag=1709f127386d0ad5176af37c0274d9c2&rtoken=hzJb104U36f1&force_default=yes&ycrid=na-b117baf985be736c84ea3629f240538f-downloader8f&ts=5a250e8f4e440&s=177b89551ffe47c397862587ac107a59ca7397d32e9c82796a8d7b7656876e0b&pb=U2FsdGVkX19xb6Ctb0XvptiTolRVOp7QvBIsKKRiYnoCmgIZHJAr6ooj93IkoOZiVVqu-AjMp8Z384Xpno6CM6ez_7oIli0WKhMQsYi5Umo",
                   CategoryId = 3,
                   ImageUrl = "https://s229iva.storage.yandex.net/rdisk/95682c502ddb26cda7b912e825b3b19aafbb72be7a266ac2979838a4ab65e74d/5e8606bb/yQXUW-T4bM2L-nrKhsj_PPc0YIlF4sZYWJymozEdzMeHDgLUuPdb-Q91REweDlyTQ4MeyDgnfK0SMJqZHNOEbw==?uid=83539494&filename=rsq8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=76531&hid=ae0c8f6ccc9536d7787e4c725f826f8c&media_type=image&tknv=v2&etag=2187c96fc7d0427d8a270d45ef3f63d9&rtoken=rAlgJ2WZXkVd&force_default=yes&ycrid=na-4bbe789c45235be883690db8eea7cc8d-downloader10e&ts=5a2509432e4c0&s=46b08469c6f3066f198e2e3e8032916093fe175a3c73c38898cfc31d575ef04a&pb=U2FsdGVkX1_VmAH9vyEPCF5CDmBW2HTvcws7nZ52adKGH7AwIq5pI11GjL_qeGW3xYdr-b3ltWzeLab4VQ8ff7HaY6xNEESQ70OXnEszOeI",
                   Name = "Audi RS Q 8",
                   ShortDescription = "Fast!",
                   LongDescription = "The RS Q8 was unveiled at the 2019 LA Auto Show in November. The engine is shared with the RS 6 C8 and RS 7 4K8, a 4.0 litre Biturbo V8 mild-hybrid petrol unit with 591bhp and 800Nm (590 lb-ft) of torque. Like the SQ8, performance is sent through the 8-speed Tiptronic automatic gearbox to its quattro all-wheel drive system.",
               });
        }
    }
}
