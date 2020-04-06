using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Shop.Migrations
{
    public partial class secondfixthumnailnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/golfethumb.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/golfeorig.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsthumb.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsorig.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/bmwi8orig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/bmwi8thumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/sclassorig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/sclassthumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/bmw7orig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/bmw7thumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/audia8orig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/audia8thumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/g63orig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/g63thumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/bmwx5orig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/unnamedthumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/rsq8orig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/rsq8thumb.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "~/Images/thumbnail/golfe.jpg", "https://s111myt.storage.yandex.net/rdisk/609b0045de6e043e2754a26df019010838ca1990bf1a75bfb09f2f3c00a779dc/5e860b36/yQXUW-T4bM2L-nrKhsj_POUja5qNr4tS3f33KJ51UBbyULqgG5hILLSEapPg8cOm2VUJ8n4M9C3XW8VbY-w_Tg==?uid=83539494&filename=golf%20e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=23203&hid=dbea2f1f0b7c020ff0157b0ebea79ad5&media_type=image&tknv=v2&etag=3b0246451cd5e2c711bac5562b73d6f9&rtoken=dAgZxatOposg&force_default=yes&ycrid=na-4b0f24f75aa2e1d3860cfc2a2f7cf273-downloader9h&ts=5a250d890b980&s=654e63de6789e41ca85af4d7aaaa7d91776c32e68d9ba0871a0e8e245e4c543d&pb=U2FsdGVkX18CFF_rLBc_nbMGK-E4gus7WpFZCcZhcbf_KdN-RdpnOvzRNZR5CSrQGqd1uQzn6s2zUKd8tdYAMdFx1mCETpDKDrOsBnR1_PI" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "~/Images/thumbnail/teslamodels.jpg", "https://s229iva.storage.yandex.net/rdisk/28263d973ea4842a5a05e3dbe337bd2e275c961e7307b8479fd567c888850f50/5e860b65/yQXUW-T4bM2L-nrKhsj_PL7bjdsxWzsNZiXSlipEancPdpjLTX0PxWgjFh3mbfXe6_CdthgyRuQS_fw7mvJwHQ==?uid=83539494&filename=tesla%20model%20s.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=15408&hid=cbf25c90edee8e8c45c18ed674a025f2&media_type=image&tknv=v2&etag=62631519bc645930521da9be7ed4d475&rtoken=dA5HbqsE7a4O&force_default=yes&ycrid=na-b74fbd6000abb266f9f3ef9f8c62416b-downloader9h&ts=5a250db5de340&s=65e34ee28217fb2ac0e4dce16f3b3b8b61d351421b2922dfde8d951bf70454f6&pb=U2FsdGVkX18a3xi4qmCbO30hgCr-eRdd4riYzh3zucEfL1r8rQ3Lk0KPVQU9cyKeqq3l0zROD_9En863MT87nKfOQgPiUfx-u9P0MADQaLk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://s51myt.storage.yandex.net/rdisk/be9ac85a4d97bcf91e547e3ab89d7509ac27646b5ebaba1ca184725451f0b2cb/5e8602cb/yQXUW-T4bM2L-nrKhsj_PPnuauj36nS79J79TvetvpXdK8XuMVWxvwx-Ly1Ao1ntyZK_j8iuCFb5eNHm2ZXYNw==?uid=83539494&filename=bmw%20i8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=158687&hid=ff01adb9eb0fe1c877989c4261ce1a22&media_type=image&tknv=v2&etag=f4afdbfa0f0a039f8fc2f16031e2950b&rtoken=AuK3azHmK75T&force_default=yes&ycrid=na-d0112279304e2a95c388c980339ceb88-downloader1h&ts=5a250581e08c0&s=347fbc7d3faab008d645e199fb5be40d03baee1b5d07fb26f2eb63198c856905&pb=U2FsdGVkX18S-NV-vM3oXkHmkrwvC0FkxhfXc1uvPWph5qTh22eJfEcFS8E0dnkCQgAQ0WsmBLFX0h9oNpBkj0JNS219XfjxxF4_9s3JbIw", "~/Images/thumbnail/bmwi8.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://s132iva.storage.yandex.net/rdisk/e89669b4eace6971a019453c6d4bb0a3d24a6c77e980a99f5757d1925e219ad1/5e8603ae/0Y13mknKtqE-NQSyRRPUROnN-Km2er7hJLb2UsmfEH2J5jx8J4ARonW4OtvNL2Dpi7f_c2e1538UwDXYCboQ1A==?uid=83539494&filename=mercedes-benz-s-klasse-front1-mini.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=321198&hid=3a1586b4c65f8edd1d1922c7d504b8ac&media_type=image&tknv=v2&etag=806615bbda4faea6b1eb7896f41af8ed&rtoken=JF4phtJpNJZm&force_default=yes&ycrid=na-7e3f5b74716afe735359e66b09668658-downloader12f&ts=5a25065a5c780&s=6909575e592a1ec6bf5ffcd4339658cb5269cb602b69c8c467f979dae8fe83ae&pb=U2FsdGVkX1895NJDcfflHlN39pga2Q81WZoSqsRW9xRFocfqTz8Bf7pGGWXiqP7W2roCP2NVITwwD0slLZRgIxOWNzsjTYo4X8sbhNNxZ5M", "~/Images/thumbnail/sclass.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://disk.yandex.kz/client/disk/Car%20shop%20files/Photos?idApp=client&dialog=slider&idDialog=%2Fdisk%2FCar%20shop%20files%2FPhotos%2Fbmw%207.jpg", "~/Images/thumbnail/bmw7.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://s228sas.storage.yandex.net/rdisk/fa5632cd06e124631d314ded7bdb7b7b3c053bb3a6821c2c8d411cc295078286/5e8604f0/OlpYcOXuxNT1pMrMnKPzGEam_L_6GBQsFEJ2oA2GxtSaM_FytNCNlGcDqYUxUtS3gl3Ppx-GaXuZbQovYbVg1w==?uid=83539494&filename=audi-a8-l-60-tfsi-e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=166829&hid=c9f09260797092f985512e406a39ffb7&media_type=image&tknv=v2&etag=8d0dd18dc0f81c6ceec9d2cb61b96982&rtoken=dE4FeKVccVdt&force_default=yes&ycrid=na-c04d78a2382006932ff07eea2a39cf35-downloader11h&ts=5a25078d71c00&s=fa71182a21eb921dcd265fa235e1dc5a75f393c1577928106a31bbbc07afd0a4&pb=U2FsdGVkX1_X5npcHQNn3D1B5MxAaiZx7beabsi2myYIDdNI2_UoO_eqD-HwfnAZ_cIL-F_HCYFkkmlvX09ypNoGjHdKJ69t9sgYR6v90tA", "~/Images/thumbnail/audia8.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://s12iva.storage.yandex.net/rdisk/50ee1b1fff7b279fc7a930a121714916d9c59c6adc0fc0b14bbc24e3a37106c8/5e860590/yQXUW-T4bM2L-nrKhsj_PLMs2DZPP8r7IQnnzNHQFGr24iXsVOPzhcuq4WqLTbD4WOS3hcNG5PV3t-F3_yhRtw==?uid=83539494&filename=g63.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=73071&hid=48ba1377109fbc57d1e58c5af405b9fc&media_type=image&tknv=v2&etag=f5b1529a851f10cfcd3ddbf3a65e02a6&rtoken=P4RWw1zrwNqd&force_default=yes&ycrid=na-0d2ddbb25a9932fe78d5047fa04d1b44-downloader4e&ts=5a25082608400&s=3cdb124e78b7a8271e40c98718406f8b0042106782d2019cef753d34db6b99bf&pb=U2FsdGVkX1-cuNONxKFUYyZ4hvMcOvQ0AIiA58XNmDiiCJDgGToWng4szaaFdkYsstjT6ERmyi3WWREA9artPR92GBVV8UEDEXIWrkqrD2U", "~/Images/thumbnail/g63.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://s559sas.storage.yandex.net/rdisk/2c9eb9d732bf37224ad40162568cb12f4a80966aba28eff445b39610463b1722/5e860648/yQXUW-T4bM2L-nrKhsj_PJP2p9pBW35FUZ8dzn2lndy6WTbKhGFxj4IE-lU8mNZJVjsNk1rGKsU_O6hcYb2m7g==?uid=83539494&filename=unnamed.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=91363&hid=d54669c15b7b502b319e4d465bd43004&media_type=image&tknv=v2&etag=bbf29aae6d386301b332db13502f6be2&rtoken=PH5eZCjMiTf7&force_default=yes&ycrid=na-0800836365d09375094648e11092e5bb-downloader4h&ts=5a2508d582200&s=25162861e35f1aab15e0c20f82051d8314bab9fac19afbb6a34b24995701dcde&pb=U2FsdGVkX19z6WJ1_8jy4Cs4IcQfAC4QJp6f8tcLtVaL-Z-34QyTHSbtzg6bwVHYeRjcSl8vWFpxRKsKBBzGBdIgOGTODAzIHPVil1S7P40", "~/Images/thumbnail/unnamed.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://s229iva.storage.yandex.net/rdisk/95682c502ddb26cda7b912e825b3b19aafbb72be7a266ac2979838a4ab65e74d/5e8606bb/yQXUW-T4bM2L-nrKhsj_PPc0YIlF4sZYWJymozEdzMeHDgLUuPdb-Q91REweDlyTQ4MeyDgnfK0SMJqZHNOEbw==?uid=83539494&filename=rsq8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=76531&hid=ae0c8f6ccc9536d7787e4c725f826f8c&media_type=image&tknv=v2&etag=2187c96fc7d0427d8a270d45ef3f63d9&rtoken=rAlgJ2WZXkVd&force_default=yes&ycrid=na-4bbe789c45235be883690db8eea7cc8d-downloader10e&ts=5a2509432e4c0&s=46b08469c6f3066f198e2e3e8032916093fe175a3c73c38898cfc31d575ef04a&pb=U2FsdGVkX1_VmAH9vyEPCF5CDmBW2HTvcws7nZ52adKGH7AwIq5pI11GjL_qeGW3xYdr-b3ltWzeLab4VQ8ff7HaY6xNEESQ70OXnEszOeI", "~/Images/thumbnail/rsq8.jpg" });
        }
    }
}
