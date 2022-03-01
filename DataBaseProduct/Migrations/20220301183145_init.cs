using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hyperion_Store.DB.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderedProduct = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SerialNumber = table.Column<int>(name: "Serial Number", type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<int>(name: "Serial Number", type: "int", nullable: false),
                    Computer = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Computers_Orders",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<int>(name: "Serial Number", type: "int", nullable: false),
                    Laptop = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laptops_Orders",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerialNumber = table.Column<int>(name: "Serial Number", type: "int", nullable: false),
                    Monitor = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.id);
                    table.ForeignKey(
                        name: "FK_Monitors_Orders",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serialnumber = table.Column<int>(name: "Serial number", type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Orders",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Computer", "OrderId", "Price", "Serial Number" },
                values: new object[,]
                {
                    { 1, "Hp Desktop  Omen GT13-1112nj,Nvidia GeForce RTX 3090,1TB SSD + 1TB SSD HyperX,i9-11900K,64GB(Win10)", null, 11989, 500 },
                    { 2, " Pavilion Desktop TP01-2200nj, Nvidia GeForce GTX 1650,512GB SSD ,i5-11400F, 16GB,(Win10)", null, 3799, 501 },
                    { 3, "Desktop Inspiron N3891-5380,  NVIDIA GeForce GTX 1650 SUPER,  256GB SSD + 1TB, i5-10400, 8GB(Win10)", null, 3999, 502 },
                    { 4, "Desktop Inspiron 3670 ,NVIDIA GeForce GT710, 128GB SSD + 1TB ,i3-8100, 4GB(Win10)", null, 2299, 503 },
                    { 5, "Legion T5 26AMR5 90RC017GYS ,NVIDIA GeForce RTX 3060.1TB + 512GB SSD,AMD Ryzen 7 3700X,16GB(win10)", null, 7699, 504 },
                    { 6, "IdeaCentre 510-15ICB 90HU004UYS,Intel UHD Graphics 630,256GB SSD,i3-8100,4GB,(win10)", null, 2399, 505 },
                    { 7, "Ultra Mini Cubi N,Intel UHD Graphics,64GB SSD, 4GB , (win10)", null, 1239, 506 }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Laptop", "OrderId", "Price", "Serial Number" },
                values: new object[,]
                {
                    { 1, "Omen 17-ck0000nj, RTX 3080, 1TB SSD,Intel® Core™I-911900,32GB,(win10)", null, 11939, 600 },
                    { 2, "Pavilion x360 14-dy0006nj, intel Iris Xᵉ Graphics ,256G SSD,,Intel® Core™i5-1135G7 Processor,8GB,(win10)", null, 3729, 601 },
                    { 3, " Pavilion x360 14-dy0010nj,intel Iris Xᵉ Graphics ,512 SSD,,Intel® Core™i7-1135G7 Processor,8GB,(win10) ", null, 3969, 602 },
                    { 4, " Pavilion 13-bb0008nj,Iris Xᵉ Graphics,256G SSD,intel® Core™ i7-1135G7 Processor,16GB,(win10) ", null, 3919, 603 },
                    { 5, "Pavilion Gaming 15-dk2002nj,  Nvidia GeForceRTX 3050,512G SSD,, intel® Core™ i7-11370G7,16GB,(win10) ", null, 9679, 604 },
                    { 6, " HP Laptop 15-dw3308nj,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,16GB,(win10) ", null, 3249, 605 },
                    { 7, "Dell Inspiron 14-5410 N5410-7748 360 ,Iris Xᵉ Graphics,512G SSD,intel® Core™ i7-1135G7 Processor,8GB,(win10) ", null, 3999, 606 },
                    { 8, "Dell Inspiron 14-5410 N5410-5514 360, Nvidia GeForce MX350,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", null, 3499, 607 },
                    { 9, "Inspiron 14-5410 N5410-5423 360, ,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", null, 3699, 608 },
                    { 10, "Vostro 15-3500 VM-RD09-12481, Intel UHD Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", null, 3439, 609 },
                    { 11, "Vostro 14-5402 VM-RD09-13057,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", null, 3649, 610 },
                    { 12, " Asus Laptop X515EA-BQ1206W , Intel UHD Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", null, 3499, 611 },
                    { 13, "Zenbook Flip 13 UX363EA-HP555W,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)", null, 4199, 612 }
                });

            migrationBuilder.InsertData(
                table: "Monitors",
                columns: new[] { "id", "Monitor", "OrderId", "Price", "Serial Number" },
                values: new object[,]
                {
                    { 1, "SamSung,24 U2422HE 23.8 FHD 1920x1080, m8, USB-C, InternetConnection ", null, 1759, 300 },
                    { 2, "Samsung, 31.5 S32A604NWM ,2560x1440 2K VA, DP,HDMI,USB ", null, 2299, 301 },
                    { 3, "Samsung, 27 S27A804UJM,UDK 4k 3840x2160 ,165Hz ,HDMIx2, DP ", null, 1119, 302 },
                    { 4, "Dell 24 E2422H ,1920x1080FHD,60Hz,VGA,DP", null, 899, 303 },
                    { 5, "Dell S2421HS 23.8,FHD 1920x1080,DP,HDMI ", null, 979, 304 },
                    { 6, "MSI 23.6 OPTIX G24C4 ,144Hz 1920x1080 FHD, AMDfreeSync, HDMIx2,DP", null, 999, 305 },
                    { 7, "MSI  Optix MAG301CR2 , 200Hz, 2560x1080,HDMIx2,DP,USB-C ", null, 1999, 306 },
                    { 8, "LG 27 LED 27GP750-B, 240Hz,1920x1080FHD-ULTRA CompGsync ,HDMIx2 DP ,mini jack 3.5", null, 1790, 307 }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "OrderId", "Phone", "Price", "Serial number" },
                values: new object[,]
                {
                    { 1, null, "IPhone 13 128G Silver", 3599, 400 },
                    { 2, null, "IPhone 13 128 Black", 3599, 401 },
                    { 3, null, "IPhone 13 256G Black", 3999, 402 },
                    { 4, null, "Iphone 13 256G Green", 3999, 403 },
                    { 5, null, "Galaxy S21 128G Black", 2959, 404 },
                    { 6, null, "Galaxy S21 128G Blue", 2959, 405 },
                    { 7, null, "Galaxy 21 Plus 128G black", 3719, 406 },
                    { 8, null, "Galaxy 21 Plus 128G Blue", 3719, 407 },
                    { 9, null, "Galaxy 21 Ultra 256G Black", 4719, 408 },
                    { 10, null, "Galaxy 21 Ultra 256G Blue", 4719, 409 },
                    { 11, null, "Realme 7 128G 4G Purple", 1299, 410 },
                    { 12, null, "Realme 7 128G 4G Blue", 1299, 411 },
                    { 13, null, "Realme 7 Pro 128G 5G Black", 1599, 412 },
                    { 14, null, "Realme 7 Pro 128G 5G Green", 1599, 413 }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "OrderId", "Phone", "Price", "Serial number" },
                values: new object[] { 15, null, "Realme X50 256G 5G Silver", 2299, 414 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "OrderId", "Phone", "Price", "Serial number" },
                values: new object[] { 16, null, "RogPhone 5 256G  8GB(ram)White", 3999, 415 });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "OrderId", "Phone", "Price", "Serial number" },
                values: new object[] { 17, null, "RogPhone 5s 256G 16GB(ram) Black", 4499, 416 });

            migrationBuilder.CreateIndex(
                name: "IX_Computers_OrderId",
                table: "Computers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_OrderId",
                table: "Laptops",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_OrderId",
                table: "Monitors",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_OrderId",
                table: "Phones",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
