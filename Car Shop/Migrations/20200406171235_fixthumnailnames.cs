using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Shop.Migrations
{
    public partial class fixthumnailnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/Images/thumbnail/golfe.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/Images/thumbnail/teslamodels.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/bmwi8.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/sclass.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/bmw7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/audia8.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/g63.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/unnamed.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ThumbImageUrl",
                value: "~/Images/thumbnail/rsq8.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://1.downloader.disk.yandex.kz/disk/15f9706f1a1ca0688ea86385cfa863e248bb18d15d06bba890504ed48421bb93/5e85ff6b/dwsY6Kws-bBmkYfopIqSkamr5hzRwyHSYjfFPcxWjbflT8FqKytosrL8rKyl4KqJq_J6bpmRyOJonT3VoXnDag%3D%3D?uid=83539494&filename=golf%20e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=143921&hid=15b5ec12348111e5cd412e99ae6ec49a&media_type=image&tknv=v2&etag=8dacdf30eff744a266c3919ef758ba40");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://s173vla.storage.yandex.net/rdisk/f499b535a265c0c64a232aa2041dabb902f817c071e0dba1a3632cc830b4185d/5e8600e2/ypoLQQd6SEXjlgH6-LDMd1ffvERwel4jWybJbqwyCXFU8HgkoGIcgVRnSuhPjJxuorkGj-6TPNCxD_Wca7YrfQ==?uid=83539494&filename=tesla%20model%20s.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=75508&hid=e0e00095069c184d0da2140a880d8043&media_type=image&tknv=v2&etag=bdb1a629ae189c8d2c23206b2c4f1314&rtoken=xZpcnTjfGpZn&force_default=yes&ycrid=na-8422a06888b27a0528680792a42b8d76-downloader24h&ts=5a2503af87c80&s=063bc46ebd34082b5b2a8bfb240dda4287ff1b715e8fe981443dac122155f0f1&pb=U2FsdGVkX18mV3gUF8brW-NUNevLnUmwzhbwjrYfKR3ZsrbgDMCcQhGF2I4AGl2VxNlEhdRcepLNvEgMXCBEeZqjyTVWKuvIcCkjU56zl0Q");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ThumbImageUrl",
                value: "https://s170iva.storage.yandex.net/rdisk/88a050d8e081ba0847606b3e00826f91100541c4bf19ac12b4fb16d9abe7558f/5e860b86/yQXUW-T4bM2L-nrKhsj_PJm-J1BnzI7wAyNpwbXuoHgLiO0pQq7p4Bj9NvG0_oVJ0SVKgHrlixsmmWbXjiW-qQ==?uid=83539494&filename=bmw%20i8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=14737&hid=94197ebf3241e5bb15b856ef2df5bea9&media_type=image&tknv=v2&etag=4f15d312c515286bfe99e2aa376e169b&rtoken=NMxW0duaIvb6&force_default=yes&ycrid=na-b29bcf6c947420a473475c098814218c-downloader3e&ts=5a250dd556d80&s=417b26e36866c6d572dd6583f07776057faa46871f56d6ce9b37cc7e42cef498&pb=U2FsdGVkX1-39jcg7n0GT0ilJdEwkWxO0oA-MFAl5BWr-bm7jYwWp4bK3O-MAZQIqpF03_uir-lO-6MPeQSrdmyMk67fRU7xR_tEX1DUCwc");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ThumbImageUrl",
                value: "https://s97iva.storage.yandex.net/rdisk/41215347a6fe646f30c12223a9268acd9f4461e81f1962d7464ddd6c21d24b48/5e860bbc/yQXUW-T4bM2L-nrKhsj_PGGp6h8qCbaBhC5N3HwMOj0mH8HnnkwJ0H0RjUPsETk5woXnlU8EagAs1qjBX_tsDA==?uid=83539494&filename=mercedes-benz-s-klasse-front1-mini.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=21026&hid=7c147e1e9b75cabdc73e39ded645a233&media_type=image&tknv=v2&etag=c013afc50577a2cbeee8364dbb5f995e&rtoken=KSDx0DALF6dy&force_default=yes&ycrid=na-f6713b6278c304aac1ecb7eb98bc7b50-downloader9e&ts=5a250e08d6700&s=7a843ee6538acf7cb9a422a7dba253d2389af287e5661a5dfe02346955616817&pb=U2FsdGVkX18Og-2ggHVai4zIbZFJq3OT7xOGwq4WDaR8ft1oZkvkND056EY8A3u3BzCtA1K3vWch-VI3IgXzqQe7X2zJWytHXEL_FYWiz_I");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ThumbImageUrl",
                value: "https://s06man.storage.yandex.net/rdisk/0f4c5ba16dd337192cb19793ae735ee7d0207b96e3113122b75a62e712153041/5e860bda/yQXUW-T4bM2L-nrKhsj_PB-dLPekFSvk79EDPz2XVyOV9ISsDq1sSdzSLEGPibA7m7yGT5Wzj1Z17nYVtN6PBA==?uid=83539494&filename=bmw%207.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=12316&hid=85500e5b8f72cb9dacddc452a6c47ab9&media_type=image&tknv=v2&etag=5248dc59f75fc06a6a53a3befd9f0864&rtoken=vDIi0Yoxk7cY&force_default=yes&ycrid=na-27b2a348b2957609ddc3258ea574396a-downloader13h&ts=5a250e2572a80&s=fdcfa765c73bfcc976868964d172ee1bc0bdd19db3342b310508d1b8a276b3de&pb=U2FsdGVkX1-R51NQAqgYL7RptBfMlcyfQiNi_w1W5GsfQvs4SnzoECA88g7fgW66xhcSvhDlox-PoL8__2-2W7c27FMyTYxE2XmKDAMg7xQ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ThumbImageUrl",
                value: "https://s20vla.storage.yandex.net/rdisk/f9b660372ca4bf2b37d98441feef119e0186d7f5af3fd119f330bfe957167f97/5e860bf0/yQXUW-T4bM2L-nrKhsj_PKkqiLjDu59_CAa_Wl0BmPxJb4_ntnrOa2XQ2YsDUMCZ8iCzZf7cPONLJSLr7p8Rew==?uid=83539494&filename=audi-a8-l-60-tfsi-e.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=20976&hid=51d355943e656ec307318eb28f52b4b0&media_type=image&tknv=v2&etag=06894d3288cfe2b365c66a5dee9f1b11&rtoken=yMTQvJY6MWXk&force_default=yes&ycrid=na-52be96980820cc4898563b33ef8aaf81-downloader13h&ts=5a250e3a6dc00&s=ad8f3b0982413c6e604ca01db4f1d6af4117d5fb2637e99c49893ed56c472a2f&pb=U2FsdGVkX1-9FUt6zRjZy1248HDNpUOlYdZ6F6Q3oGtyR8l3NCkkD3O2QJR6-tBQARxG1DnvhP9bW9gE2hMrPP4rSXJ8pkfijJX2qywXWj0");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ThumbImageUrl",
                value: "https://s235vla.storage.yandex.net/rdisk/31868ce61722a5c5bde5c2659840ecd2c3df862b439768eb0c55e717fe3b2144/5e860c0e/yQXUW-T4bM2L-nrKhsj_PCVWbmWzb9Jra52XHpHMobyktgpH5DZvrTeTbODTR8ryxrc-DYOFNf3IPNXuG0ug6A==?uid=83539494&filename=g63.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=16930&hid=f6258e8a35ed62ba893e4569a8e5c901&media_type=image&tknv=v2&etag=eaed4ff9e06d086bb2add24eb4fc5a44&rtoken=BPLclenhMlmR&force_default=yes&ycrid=na-fe1c707fb2de8ff0103bbfe2c28b3e37-downloader13h&ts=5a250e5709f80&s=97a2c54cccb6e9d6d428f645f288452d9fbbabe5c1ab7ca9370866e61abcd3f2&pb=U2FsdGVkX1-oQz0c8-o_v8nNMirAkGyIbdNpCYXtvV6Rv4XRgnE0Ojtg_M20KR8jZ5GColZcb5oGF4zMJuIXN-OameAIC4ejSN9SoNEFFLw");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ThumbImageUrl",
                value: "https://s286iva.storage.yandex.net/rdisk/b0a9afad3335188a2c5340df15c955e7076d78e391962a7192204cf6c5e831fb/5e860c31/yQXUW-T4bM2L-nrKhsj_PFl_h7XKuHqXq7GrG1uos0yuADCZvewB9j7kqT4e0RPpx9pxIu1Ephtr4m767Ihjiw==?uid=83539494&filename=unnamed.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=31656&hid=b6488c30f9c0f2df95c8338ccb276233&media_type=image&tknv=v2&etag=d50e5dbc761771c45103e55c95d3fadf&rtoken=NmnuhHpQRKH8&force_default=yes&ycrid=na-c856272cb5b101632e325934eb683eb5-downloader8f&ts=5a250e786ae40&s=28ee83d0778b8a34d6d3368908c4966350168cc8473bfca599888bf3bb82f934&pb=U2FsdGVkX1-nAtJdOYFVxFlQFgGVx-7GjokFL8PP793b3wq-Ci0NzWfAhldPvGd0xeU2UOVuaesFqgmkI-G7_7oF3mePr5jXTCYavncy_rc");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ThumbImageUrl",
                value: "https://s139myt.storage.yandex.net/rdisk/8f2b83903cdc7422013158d1faf6febd1758e4879c739cce2df3f3913f6b3640/5e860c49/yQXUW-T4bM2L-nrKhsj_PLmeLqI1c8WVjv7uIQBXxd7hR864kujYhnJYBufv_o7g2VncEiRtBTLAmw6Itswi1A==?uid=83539494&filename=rsq8.jpg&disposition=inline&hash=&limit=0&content_type=image%2Fjpeg&owner_uid=83539494&fsize=19222&hid=cb0222ce652a7b2686a93802a015c1ee&media_type=image&tknv=v2&etag=1709f127386d0ad5176af37c0274d9c2&rtoken=hzJb104U36f1&force_default=yes&ycrid=na-b117baf985be736c84ea3629f240538f-downloader8f&ts=5a250e8f4e440&s=177b89551ffe47c397862587ac107a59ca7397d32e9c82796a8d7b7656876e0b&pb=U2FsdGVkX19xb6Ctb0XvptiTolRVOp7QvBIsKKRiYnoCmgIZHJAr6ooj93IkoOZiVVqu-AjMp8Z384Xpno6CM6ez_7oIli0WKhMQsYi5Umo");
        }
    }
}
