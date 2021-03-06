// <auto-generated />
using System;
using Hyperion_Store.DB.DataProduct;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hyperion_Store.DB.Migrations
{
    [DbContext(typeof(Electronic_storeContext))]
    [Migration("20220301183145_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Computer1")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Computer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int")
                        .HasColumnName("Serial Number");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Computers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Computer1 = "Hp Desktop  Omen GT13-1112nj,Nvidia GeForce RTX 3090,1TB SSD + 1TB SSD HyperX,i9-11900K,64GB(Win10)",
                            Price = 11989,
                            SerialNumber = 500
                        },
                        new
                        {
                            Id = 2,
                            Computer1 = " Pavilion Desktop TP01-2200nj, Nvidia GeForce GTX 1650,512GB SSD ,i5-11400F, 16GB,(Win10)",
                            Price = 3799,
                            SerialNumber = 501
                        },
                        new
                        {
                            Id = 3,
                            Computer1 = "Desktop Inspiron N3891-5380,  NVIDIA GeForce GTX 1650 SUPER,  256GB SSD + 1TB, i5-10400, 8GB(Win10)",
                            Price = 3999,
                            SerialNumber = 502
                        },
                        new
                        {
                            Id = 4,
                            Computer1 = "Desktop Inspiron 3670 ,NVIDIA GeForce GT710, 128GB SSD + 1TB ,i3-8100, 4GB(Win10)",
                            Price = 2299,
                            SerialNumber = 503
                        },
                        new
                        {
                            Id = 5,
                            Computer1 = "Legion T5 26AMR5 90RC017GYS ,NVIDIA GeForce RTX 3060.1TB + 512GB SSD,AMD Ryzen 7 3700X,16GB(win10)",
                            Price = 7699,
                            SerialNumber = 504
                        },
                        new
                        {
                            Id = 6,
                            Computer1 = "IdeaCentre 510-15ICB 90HU004UYS,Intel UHD Graphics 630,256GB SSD,i3-8100,4GB,(win10)",
                            Price = 2399,
                            SerialNumber = 505
                        },
                        new
                        {
                            Id = 7,
                            Computer1 = "Ultra Mini Cubi N,Intel UHD Graphics,64GB SSD, 4GB , (win10)",
                            Price = 1239,
                            SerialNumber = 506
                        });
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Laptop1")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Laptop");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int")
                        .HasColumnName("Serial Number");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Laptops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Laptop1 = "Omen 17-ck0000nj, RTX 3080, 1TB SSD,Intel® Core™I-911900,32GB,(win10)",
                            Price = 11939,
                            SerialNumber = 600
                        },
                        new
                        {
                            Id = 2,
                            Laptop1 = "Pavilion x360 14-dy0006nj, intel Iris Xᵉ Graphics ,256G SSD,,Intel® Core™i5-1135G7 Processor,8GB,(win10)",
                            Price = 3729,
                            SerialNumber = 601
                        },
                        new
                        {
                            Id = 3,
                            Laptop1 = " Pavilion x360 14-dy0010nj,intel Iris Xᵉ Graphics ,512 SSD,,Intel® Core™i7-1135G7 Processor,8GB,(win10) ",
                            Price = 3969,
                            SerialNumber = 602
                        },
                        new
                        {
                            Id = 4,
                            Laptop1 = " Pavilion 13-bb0008nj,Iris Xᵉ Graphics,256G SSD,intel® Core™ i7-1135G7 Processor,16GB,(win10) ",
                            Price = 3919,
                            SerialNumber = 603
                        },
                        new
                        {
                            Id = 5,
                            Laptop1 = "Pavilion Gaming 15-dk2002nj,  Nvidia GeForceRTX 3050,512G SSD,, intel® Core™ i7-11370G7,16GB,(win10) ",
                            Price = 9679,
                            SerialNumber = 604
                        },
                        new
                        {
                            Id = 6,
                            Laptop1 = " HP Laptop 15-dw3308nj,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,16GB,(win10) ",
                            Price = 3249,
                            SerialNumber = 605
                        },
                        new
                        {
                            Id = 7,
                            Laptop1 = "Dell Inspiron 14-5410 N5410-7748 360 ,Iris Xᵉ Graphics,512G SSD,intel® Core™ i7-1135G7 Processor,8GB,(win10) ",
                            Price = 3999,
                            SerialNumber = 606
                        },
                        new
                        {
                            Id = 8,
                            Laptop1 = "Dell Inspiron 14-5410 N5410-5514 360, Nvidia GeForce MX350,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)",
                            Price = 3499,
                            SerialNumber = 607
                        },
                        new
                        {
                            Id = 9,
                            Laptop1 = "Inspiron 14-5410 N5410-5423 360, ,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)",
                            Price = 3699,
                            SerialNumber = 608
                        },
                        new
                        {
                            Id = 10,
                            Laptop1 = "Vostro 15-3500 VM-RD09-12481, Intel UHD Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)",
                            Price = 3439,
                            SerialNumber = 609
                        },
                        new
                        {
                            Id = 11,
                            Laptop1 = "Vostro 14-5402 VM-RD09-13057,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)",
                            Price = 3649,
                            SerialNumber = 610
                        },
                        new
                        {
                            Id = 12,
                            Laptop1 = " Asus Laptop X515EA-BQ1206W , Intel UHD Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)",
                            Price = 3499,
                            SerialNumber = 611
                        },
                        new
                        {
                            Id = 13,
                            Laptop1 = "Zenbook Flip 13 UX363EA-HP555W,Iris Xᵉ Graphics,512G SSD,intel® Core™ i5-1135G7 Processor,8GB,(win10)",
                            Price = 4199,
                            SerialNumber = 612
                        });
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Monitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Monitor1")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Monitor");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int")
                        .HasColumnName("Serial Number");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Monitors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Monitor1 = "SamSung,24 U2422HE 23.8 FHD 1920x1080, m8, USB-C, InternetConnection ",
                            Price = 1759,
                            SerialNumber = 300
                        },
                        new
                        {
                            Id = 2,
                            Monitor1 = "Samsung, 31.5 S32A604NWM ,2560x1440 2K VA, DP,HDMI,USB ",
                            Price = 2299,
                            SerialNumber = 301
                        },
                        new
                        {
                            Id = 3,
                            Monitor1 = "Samsung, 27 S27A804UJM,UDK 4k 3840x2160 ,165Hz ,HDMIx2, DP ",
                            Price = 1119,
                            SerialNumber = 302
                        },
                        new
                        {
                            Id = 4,
                            Monitor1 = "Dell 24 E2422H ,1920x1080FHD,60Hz,VGA,DP",
                            Price = 899,
                            SerialNumber = 303
                        },
                        new
                        {
                            Id = 5,
                            Monitor1 = "Dell S2421HS 23.8,FHD 1920x1080,DP,HDMI ",
                            Price = 979,
                            SerialNumber = 304
                        },
                        new
                        {
                            Id = 6,
                            Monitor1 = "MSI 23.6 OPTIX G24C4 ,144Hz 1920x1080 FHD, AMDfreeSync, HDMIx2,DP",
                            Price = 999,
                            SerialNumber = 305
                        },
                        new
                        {
                            Id = 7,
                            Monitor1 = "MSI  Optix MAG301CR2 , 200Hz, 2560x1080,HDMIx2,DP,USB-C ",
                            Price = 1999,
                            SerialNumber = 306
                        },
                        new
                        {
                            Id = 8,
                            Monitor1 = "LG 27 LED 27GP750-B, 240Hz,1920x1080FHD-ULTRA CompGsync ,HDMIx2 DP ,mini jack 3.5",
                            Price = 1790,
                            SerialNumber = 307
                        });
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OrderedProduct")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("SerialNumber")
                        .HasColumnType("int")
                        .HasColumnName("Serial Number");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Phone");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int")
                        .HasColumnName("Serial number");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Phones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Phone1 = "IPhone 13 128G Silver",
                            Price = 3599,
                            SerialNumber = 400
                        },
                        new
                        {
                            Id = 2,
                            Phone1 = "IPhone 13 128 Black",
                            Price = 3599,
                            SerialNumber = 401
                        },
                        new
                        {
                            Id = 3,
                            Phone1 = "IPhone 13 256G Black",
                            Price = 3999,
                            SerialNumber = 402
                        },
                        new
                        {
                            Id = 4,
                            Phone1 = "Iphone 13 256G Green",
                            Price = 3999,
                            SerialNumber = 403
                        },
                        new
                        {
                            Id = 5,
                            Phone1 = "Galaxy S21 128G Black",
                            Price = 2959,
                            SerialNumber = 404
                        },
                        new
                        {
                            Id = 6,
                            Phone1 = "Galaxy S21 128G Blue",
                            Price = 2959,
                            SerialNumber = 405
                        },
                        new
                        {
                            Id = 7,
                            Phone1 = "Galaxy 21 Plus 128G black",
                            Price = 3719,
                            SerialNumber = 406
                        },
                        new
                        {
                            Id = 8,
                            Phone1 = "Galaxy 21 Plus 128G Blue",
                            Price = 3719,
                            SerialNumber = 407
                        },
                        new
                        {
                            Id = 9,
                            Phone1 = "Galaxy 21 Ultra 256G Black",
                            Price = 4719,
                            SerialNumber = 408
                        },
                        new
                        {
                            Id = 10,
                            Phone1 = "Galaxy 21 Ultra 256G Blue",
                            Price = 4719,
                            SerialNumber = 409
                        },
                        new
                        {
                            Id = 11,
                            Phone1 = "Realme 7 128G 4G Purple",
                            Price = 1299,
                            SerialNumber = 410
                        },
                        new
                        {
                            Id = 12,
                            Phone1 = "Realme 7 128G 4G Blue",
                            Price = 1299,
                            SerialNumber = 411
                        },
                        new
                        {
                            Id = 13,
                            Phone1 = "Realme 7 Pro 128G 5G Black",
                            Price = 1599,
                            SerialNumber = 412
                        },
                        new
                        {
                            Id = 14,
                            Phone1 = "Realme 7 Pro 128G 5G Green",
                            Price = 1599,
                            SerialNumber = 413
                        },
                        new
                        {
                            Id = 15,
                            Phone1 = "Realme X50 256G 5G Silver",
                            Price = 2299,
                            SerialNumber = 414
                        },
                        new
                        {
                            Id = 16,
                            Phone1 = "RogPhone 5 256G  8GB(ram)White",
                            Price = 3999,
                            SerialNumber = 415
                        },
                        new
                        {
                            Id = 17,
                            Phone1 = "RogPhone 5s 256G 16GB(ram) Black",
                            Price = 4499,
                            SerialNumber = 416
                        });
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Computer", b =>
                {
                    b.HasOne("Hyperion_Store.DB.DataProduct.Order", "Order")
                        .WithMany("Computers")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Computers_Orders");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Laptop", b =>
                {
                    b.HasOne("Hyperion_Store.DB.DataProduct.Order", "Order")
                        .WithMany("Laptops")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Laptops_Orders");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Monitor", b =>
                {
                    b.HasOne("Hyperion_Store.DB.DataProduct.Order", "Order")
                        .WithMany("Monitors")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Monitors_Orders");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Order", b =>
                {
                    b.HasOne("Hyperion_Store.DB.DataProduct.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Phone", b =>
                {
                    b.HasOne("Hyperion_Store.DB.DataProduct.Order", "Order")
                        .WithMany("Phones")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Phones_Orders");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Hyperion_Store.DB.DataProduct.Order", b =>
                {
                    b.Navigation("Computers");

                    b.Navigation("Laptops");

                    b.Navigation("Monitors");

                    b.Navigation("Phones");
                });
#pragma warning restore 612, 618
        }
    }
}
